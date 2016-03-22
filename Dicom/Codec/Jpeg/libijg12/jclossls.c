#pragma region License (non-CC)

// This source code contains the work of the Independent JPEG Group.
// Please see accompanying notice in code comments and/or readme file
// for the terms of distribution and use regarding this code.

#pragma endregion

/*
 * jclossls.c
 *
 * Copyright (C) 1998, Thomas G. Lane.
 * This file is part of the Independent JPEG Group's software.
 * For conditions of distribution and use, see the accompanying README file.
 *
 * This file contains the control logic for the lossless JPEG compressor.
 */

#define JPEG_INTERNALS
#include "jinclude12.h"
#include "jpeglib12.h"
#include "jlossls12.h"


#ifdef C_LOSSLESS_SUPPORTED

/*
 * Initialize for a processing pass.
 */

METHODDEF(void)
start_pass (j_compress_ptr cinfo, J_BUF_MODE pass_mode)
{
  j_lossless_c_ptr losslsc = (j_lossless_c_ptr) cinfo->codec;

  (*losslsc->scaler_start_pass) (cinfo);
  (*losslsc->predict_start_pass) (cinfo);
  (*losslsc->diff_start_pass) (cinfo, pass_mode);
}


/*
 * Initialize the lossless compression codec.
 * This is called only once, during master selection.
 */

GLOBAL(void) 
jinit_lossless_c_codec(j_compress_ptr cinfo)
{
  j_lossless_c_ptr losslsc;

  /* Create subobject in permanent pool */
  losslsc = (j_lossless_c_ptr)
    (*cinfo->mem->alloc_small) ((j_common_ptr) cinfo, JPOOL_PERMANENT,
				SIZEOF(jpeg_lossless_c_codec));
  cinfo->codec = (struct jpeg_c_codec *) losslsc;

  /* Initialize sub-modules */

  /* Scaler */
  jinit_c_scaler(cinfo);

  /* Differencer */
  jinit_differencer(cinfo);

  /* Entropy encoding: either Huffman or arithmetic coding. */
  if (cinfo->arith_code) {
#ifdef WITH_ARITHMETIC_PATCH
    jinit_arith_encoder(cinfo);
#else
    ERREXIT(cinfo, JERR_ARITH_NOTIMPL);
#endif
  } else {
    jinit_lhuff_encoder(cinfo);
  }

  /* Need a full-image difference buffer in any multi-pass mode. */
  jinit_c_diff_controller(cinfo,
			  (boolean) (cinfo->num_scans > 1 ||
				     cinfo->optimize_coding));

  /* Initialize method pointers.
   *
   * Note: entropy_start_pass and entropy_finish_pass are assigned in
   * jclhuff.c and compress_data is assigned in jcdiffct.c.
   */
  losslsc->pub.start_pass = start_pass;
}

#endif /* C_LOSSLESS_SUPPORTED */
