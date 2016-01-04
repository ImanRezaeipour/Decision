﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web;
using System.Web.Mvc;
using Decision.ViewModel.Common;

namespace Decision.ViewModel.EntireEvaluation
{
    /// <summary>
    /// ویومدل ویرایش ارزیابی از استاد
    /// </summary>
    public class EditEntireEvaluationViewModel : BaseRowVersion
    {
        #region Properties
        /// <summary>
        /// آی دی ارزیابی از استاد
        /// </summary>
        public  Guid Id { get; set; }

        /// <summary>
        ///  نظریه کلی برای استاد
        /// </summary>
        [Required(ErrorMessage = "لطفا متن ارزیابی را وارد کنید")]
        [DisplayName("متن ارزیابی")]
        [AllowHtml]
        public  string Content { get; set; }

        /// <summary>
        /// تاریخ ارزیابی
        /// </summary>
        [DisplayName("تاریخ")]
        [Required(ErrorMessage = "لطفا تاریخ ارزیابی را مشخص کنید")]
        public  DateTime EvaluationDate { get; set; }

        /// <summary>
        /// خلاصه ارزیابی 
        /// </summary>
        [Required(ErrorMessage = "لطفا خلاصه ارزیابی را وارد کنید")]
        [AllowHtml]
        [DisplayName("خلاصه ارزیابی")]
        public  string Brief { get; set; }

        /// <summary>
        /// نقاط ضعف استاد
        /// </summary>
        [Required(ErrorMessage = "لطفا نقاط ضعف استاد را وارد کنید")]
        [AllowHtml]
        [DisplayName("نقاط ضعف")]
        public  string Foible { get; set; }

        /// <summary>
        /// نقطه قوت استاد
        /// </summary>
        [Required(ErrorMessage = "لطفا نقاط قوت استاد را وارد کنید")]
        [DisplayName("نقاط قوت")]
        [AllowHtml]
        public  string StrongPoint { get; set; }

        /// <summary>
        /// اسکن فایل ضمیمه ارزیابی
        /// </summary>
        ///
        public  string AttachmentScan { get; set; }

        /// <summary>
        /// فایل ضمیمه ارزیابی
        /// </summary>
        [DisplayName("فایل ضمیمه")]
        public  HttpPostedFileBase AttachmentFile { get; set; }

        /// <summary>
        /// آی دی استاد ارزیابی شده
        /// </summary>
        [Required]
        public  Guid TeacherId { get; set; }

        /// <summary>
        /// آی دی ارزیاب
        /// </summary>
        [Required(ErrorMessage = "لطفا ارزیاب را انتخاب کنید")]
        [DisplayName("ارزیاب")]
        public  Guid EvaluatorId { get; set; }
        #endregion

        #region SelectListIten
        /// <summary>
        /// لیست ارزیاب ها برای لیست آبشاری در ویو
        /// </summary>
        public  IEnumerable<SelectListItem> Evaluators { get; set; }
        #endregion
    }
}