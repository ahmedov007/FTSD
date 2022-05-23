
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;


namespace FTSD2.Models
{
    public class OperationContractsViewModel 
    {
    }


    public class OperationContractsPreparationViewModel
    {
        public Guid Id { get; set; }

        [Display(Name = "اسم العقد باللغه العربية")]
        [Required(ErrorMessage = "يجب ادخال اسم العقد باللغه العربية")]
        public string NameArabic { get; set; }


        [Display(Name = "اسم العقد باللغه بالانجليزية")]
        [Required(ErrorMessage = "يجب ادخال اسم العقد باللغه بالانجليزية")]
        public string Name { get; set; }

        [Display(Name = "المنطقة")]
        [Required(ErrorMessage = "يجب اختيار المنطقة")]
        public int RegionId { get; set; }

        [Display(Name = "نوع العقد")]
        [Required(ErrorMessage = "يجب اختيار نوع العقد")]
        public int ContractTypeId { get; set; }

        [Display(Name = "تاريخ طلب العقد")]
        [Required(ErrorMessage = "يجب اختيار تاريخ طلب العقد")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MMM/yyyy}")]
        public DateTime? RequestDate { get; set; }

        [Display(Name = "صاحب الصلاحية")]
        [Required(ErrorMessage = "يجب اختيار صاحب الصلاحية")]
        public int AthorityApproval { get; set; }

        [Display(Name = "المقاول")]
        [Required(ErrorMessage = "يجب اختيار المقاول")]
        public Guid? CompanyId { get; set; }

        [Display(Name = "تاريخ استلام العقد")]
        [Required(ErrorMessage = "يجب اختيار تاريخ استلام العقد")]
        public DateTime? ContractRequestDate { get; set; }

        [Display(Name = "تاريخ الترسية")]
        [Required(ErrorMessage = "يجب اختيار تاريخ الترسية")]
        public DateTime? WavierDate { get; set; }

        [Display(Name = "تاريخ اعتماد خطاب الاستثناء ")]
        [Required(ErrorMessage = "يجب اختيار تاريخ اعتماد خطاب الاستثناء")]
        public DateTime? AwardingApprovalDate { get; set; }

        [Display(Name = "تاريخ توقيع العقد")]
        [Required(ErrorMessage = "يجب اختيار تاريخ توقيع العقد")]
        public DateTime? SigningDate { get; set; }

        [Display(Name = "تاريخ توقيع المقاول")]
        [Required(ErrorMessage = "يجب اختيار تاريخ توقيع المقاول ")]
        public DateTime? ContractorDate { get; set; }

        [Display(Name = "تاريخ فتح العطاءات")]
        [Required(ErrorMessage = "يجب اختيار تاريخ فتح العطاءات")]
        public DateTime? OpenBidDate { get; set; }

        [Display(Name = "تاريخ تقييم العطاءات")]
        [Required(ErrorMessage = "يجب اختيار تاريخ تقييم العطاءات")]
        public DateTime? BidEvaluationDate { get; set; }

        [Display(Name = "تاريخ شرح العمل ")]
        [Required(ErrorMessage = "يجب اختيار تاريخ شرح العمل ")]
        public DateTime? JobexDate { get; set; }


    }

    public class OperationContractsPreparationAddViewModel
    {
        public Guid Id { get; set; }

        [Display(Name = "اسم العقد باللغه العربية")]
        [Required(ErrorMessage = "يجب ادخال اسم العقد باللغه العربية")]
        public string NameArabic { get; set; }


        [Display(Name = "اسم العقد باللغه بالانجليزية")]
        [Required(ErrorMessage = "يجب ادخال اسم العقد باللغه بالانجليزية")]
        public string Name { get; set; }

        [Display(Name = "صاحب الصلاحية")]
        [Required(ErrorMessage = "يجب اختيار صاحب الصلاحية")]
        public int AthorityApproval { get; set; }

        [Display(Name = "المنطقة")]
        [Required(ErrorMessage = "يجب اختيار المنطقة")]
        public int RegionId { get; set; }

        [Display(Name = "نوع العقد")]
        [Required(ErrorMessage = "يجب اختيار نوع العقد")]
        public int ContractTypeId { get; set; }

        [Display(Name = "تاريخ طلب العقد")]
        [Required(ErrorMessage = "يجب اختيار تاريخ طلب العقد")]
        public DateTime? RequestDate { get; set; }


        [Display(Name = "المقاول")]
        [Required(ErrorMessage = "يجب اختيار المقاول")]
        public Guid? CompanyId { get; set; }


        [Display(Name = "تاريخ استلام العقد")]
        [Required(ErrorMessage = "يجب اختيار تاريخ استلام العقد")]
        public DateTime? ContractRequestDate { get; set; }

        [Display(Name = "تاريخ الترسية")]
        [Required(ErrorMessage = "يجب اختيار تاريخ الترسية")]
        public DateTime? WavierDate { get; set; }


        [Display(Name = "تاريخ اعتماد خطاب الاستثناء ")]
        [Required(ErrorMessage = "يجب اختيار تاريخ اعتماد خطاب الاستثناء")]
        public DateTime? AwardingApprovalDate { get; set; }

        [Display(Name = "تاريخ توقيع العقد")]
        [Required(ErrorMessage = "يجب اختيار تاريخ توقيع العقد")]
        public DateTime? SigningDate { get; set; }

        [Display(Name = "تاريخ توقيع المقاول")]
        [Required(ErrorMessage = "يجب اختيار تاريخ توقيع المقاول ")]
        public DateTime? ContractorDate { get; set; }

        [Display(Name = "تاريخ فتح العطاءات")]
        [Required(ErrorMessage = "يجب اختيار تاريخ فتح العطاءات")]
        public DateTime? OpenBidDate { get; set; }

        [Display(Name = "تاريخ تقييم العطاءات")]
        [Required(ErrorMessage = "يجب اختيار تاريخ تقييم العطاءات")]
        public DateTime? BidEvaluationDate { get; set; }

        [Display(Name = "تاريخ شرح العمل ")]
        [Required(ErrorMessage = "يجب اختيار تاريخ شرح العمل ")]
        public DateTime? JobexDate { get; set; }


    }


    public class OperationContractsActiveViewModel
    {
        public Guid Id { get; set; }
        public string ActiveId { get; set; }

        [Display(Name = "رقم العقد")]
        [Required(ErrorMessage = "يجب ادخال رقم العقد")]
        public string ContractNumber { get; set; }

        [Display(Name = "اسم العقد باللغه العربية")]
        [Required(ErrorMessage = "يجب ادخال اسم العقد باللغه العربية")]
        public string NameArabic { get; set; }

        [Display(Name = "اسم العقد باللغه بالانجليزية")]
        [Required(ErrorMessage = "يجب ادخال اسم العقد باللغه بالانجليزية")]
        public string Name { get; set; }

        [Display(Name = "المنطقة")]
        [Required(ErrorMessage = "يجب اختيار المنطقة")]
        public int RegionId { get; set; }

        [Display(Name = "نوع العقد")]
        [Required(ErrorMessage = "يجب اختيار نوع العقد")]
        public string ContractTypeId { get; set; }

        [Display(Name = "المقاول")]
        [Required(ErrorMessage = "يجب اختيار المقاول")]
        public string CompanyId { get; set; }

        [Display(Name = "تاريخ بداية العقد")]
        [Required(ErrorMessage = "يجب اختيار تاريخ بداية العقد")]
        public DateTime? StartDate { get; set; }

        [Display(Name = "تاريخ نهاية العقد")]
        [Required(ErrorMessage = "يجب اختيار تاريخ نهاية العقد")]
        public DateTime? EndDate { get; set; }

        [Display(Name = "قيمة الفترة الأساسية")]
        [Required(ErrorMessage = "يجب ادخال قيمة الفترة الأساسية")]
        public float? BasicPeriodCost { get; set; }

        [Display(Name = "قيمة الفترة الاختيارية")]
        [Required(ErrorMessage = "يجب ادخال قيمة الفترة الاختيارية")]
        public float? OptionalPeriodCost { get; set; }

        [Display(Name = "المبلغ المقطوع")]
        [Required(ErrorMessage = "يجب ادخال المبلغ المقطوع")]
        public float? LumpSum { get; set; }

        [Display(Name = "سعر الوحدة")]
        [Required(ErrorMessage = "يجب ادخال سعر الوحدة")]
        public float? Uitrate { get; set; }

        [Display(Name = "العمل الاختياري")]
        [Required(ErrorMessage = "يجب ادخال العمل الاختياري")]
        public float? OptionalValue { get; set; }

        [Display(Name = "إجمالي قيمة العقد")]
        [Required(ErrorMessage = "يجب ادخال إجمالي قيمة العقد")]
        public float? CotractTotal { get; set; }

    }

    public class OperationContractsActiveAddViewModel
    {
        public Guid Id { get; set; }

        [Display(Name = "رقم العقد")]
        [Required(ErrorMessage = "يجب ادخال رقم العقد")]
        public string ContractNumber { get; set; }

        [Display(Name = "اسم العقد باللغه العربية")]
        [Required(ErrorMessage = "يجب ادخال اسم العقد باللغه العربية")]
        public string NameArabic { get; set; }

        [Display(Name = "اسم العقد باللغه بالانجليزية")]
        [Required(ErrorMessage = "يجب ادخال اسم العقد باللغه بالانجليزية")]
        public string Name { get; set; }

        [Display(Name = "نوع العقد")]
        [Required(ErrorMessage = "يجب اختيار نوع العقد")]
        public int ContractTypeId { get; set; }

        [Display(Name = "المقاول")]
        [Required(ErrorMessage = "يجب اختيار المقاول")]
        public string CompanyId { get; set; }

        [Display(Name = "المنطقة")]
        [Required(ErrorMessage = "يجب اختيار المنطقة")]
        public int RegionId { get; set; }


        [Display(Name = "تاريخ بداية العقد")]
        [Required(ErrorMessage = "يجب اختيار تاريخ بداية العقد")]
        public DateTime? StartDate { get; set; }

        [Display(Name = "تاريخ نهاية العقد")]
        [Required(ErrorMessage = "يجب اختيار تاريخ نهاية العقد")]
        public DateTime? EndDate { get; set; }

        [Display(Name = "المبلغ المقطوع")]
        [Required(ErrorMessage = "يجب ادخال المبلغ المقطوع")]
        public float? LumpSum { get; set; }

        [Display(Name = "قيمة الفترة الأساسية")]
        [Required(ErrorMessage = "يجب ادخال قيمة الفترة الأساسية")]
        public float? BasicPeriodCost { get; set; }

        [Display(Name = "قيمة الفترة الاختيارية")]
        [Required(ErrorMessage = "يجب ادخال قيمة الفترة الاختيارية")]
        public float? OptionalPeriodCost { get; set; }

        [Display(Name = "سعر الوحدة")]
        [Required(ErrorMessage = "يجب ادخال سعر الوحدة")]
        public float? Uitrate { get; set; }

        [Display(Name = "العمل الاختياري")]
        [Required(ErrorMessage = "يجب ادخال العمل الاختياري")]
        public float? OptionalValue { get; set; }

        [Display(Name = "إجمالي قيمة العقد")]
        [Required(ErrorMessage = "يجب ادخال إجمالي قيمة العقد")]
        public float? CotractTotal { get; set; }


    }

    public class OperationContractsUnderModificationAddViewModel
    {
        public Guid Id { get; set; }

        [Display(Name = "رقم العقد")]
        [Required(ErrorMessage = "يجب ادخال رقم العقد")]
        public string ContractNo { get; set; }

        [Display(Name = "اسم العقد باللغه العربية")]
        [Required(ErrorMessage = "يجب ادخال اسم العقد باللغه العربية")]
        public string ArabicContractName { get; set; }


        [Display(Name = "اسم العقد باللغه بالانجليزية")]
        [Required(ErrorMessage = "يجب ادخال اسم العقد باللغه بالانجليزية")]
        public string ContractName { get; set; }

      

        [Display(Name = "المقاول")]
        [Required(ErrorMessage = "يجب اختيار المقاول")]
        public string CompanyId { get; set; }

        [Display(Name = "نوع العقد")]
        [Required(ErrorMessage = "يجب اختيار نوع العقد")]
        public int ContractTypeId { get; set; }


        [Display(Name = "صاحب الصلاحية")]
        [Required(ErrorMessage = "يجب اختيار صاحب الصلاحية")]
        public int AthorityApproval { get; set; }

        [Display(Name = "مدة العقد")]
        [Required(ErrorMessage = "يجب ادخال مدة العقد")]
        public int? ModificationDuration { get; set; }

        [Display(Name = "الاجراء")]
        [Required(ErrorMessage = "يجب اختيار الاجراء")]
        public int? NewContractActionId { get; set; }

        [Display(Name = "قيمة التعديل")]
        [Required(ErrorMessage = "يجب ادخال قيمة التعديل")]
        public float? AmendmentCost { get; set; }

        [Display(Name = "نسبة التعديل")]
        [Required(ErrorMessage = "يجب ادخال قيمة التعديل")]
        public int? AmendmentPercentage { get; set; }

        [Display(Name = "تاريخ اعتماد خطاب المبررات")]
        [Required(ErrorMessage = "يجب ادخال نسبة التعديل")]
        public DateTime? AmendmentLetterApprovalDate { get; set; }

        [Display(Name = "تاريخ طلب التعديل")]
        [Required(ErrorMessage = "يجب اختيار تاريخ طلب التعديل")]
        public DateTime? AmendmentRequestDate { get; set; }

        [Display(Name = "تاريخ التوقيع من صاحب الصلاحية")]
        [Required(ErrorMessage = "يجب اختيار تاريخ التوقيع من صاحب الصلاحية")]
        public DateTime? SigntureDate { get; set; }

        [Display(Name = "تاريخ توقيع المقاول")]
        [Required(ErrorMessage = "يجب اختيار تاريخ توقيع المقاول")]
        public DateTime? ContractorSignutreDate { get; set; }

    }

    public class OperationContractsUnderModificationViewModel
    {
        public Guid Id { get; set; }

        [Display(Name = "رقم العقد")]
        [Required(ErrorMessage = "يجب ادخال رقم العقد")]
        public string ContractNo { get; set; }

        [Display(Name = "اسم العقد باللغه العربية")]
        [Required(ErrorMessage = "يجب ادخال اسم العقد باللغه العربية")]
        public string ArabicContractName { get; set; }


        [Display(Name = "اسم العقد باللغه بالانجليزية")]
        [Required(ErrorMessage = "يجب ادخال اسم العقد باللغه بالانجليزية")]
        public string ContractName { get; set; }

       

        [Display(Name = "المقاول")]
        [Required(ErrorMessage = "يجب اختيار المقاول")]
        public string CompanyId { get; set; }

        [Display(Name = "نوع العقد")]
        [Required(ErrorMessage = "يجب اختيار نوع العقد")]
        public string ContractTypeId { get; set; }


        [Display(Name = "صاحب الصلاحية")]
        [Required(ErrorMessage = "يجب اختيار صاحب الصلاحية")]
        public int AthorityApproval { get; set; }

        [Display(Name = "مدة العقد")]
        [Required(ErrorMessage = "يجب ادخال مدة العقد")]
        public int? ModificationDuration { get; set; }

        [Display(Name = "الاجراء")]
        [Required(ErrorMessage = "يجب اختيار الاجراء")]
        public int? NewContractActionId { get; set; }

        [Display(Name = "قيمة التعديل")]
        [Required(ErrorMessage = "يجب ادخال قيمة التعديل")]
        public float? AmendmentCost { get; set; }

        [Display(Name = "نسبة التعديل")]
        [Required(ErrorMessage = "يجب ادخال قيمة التعديل")]
        public int? AmendmentPercentage { get; set; }

        [Display(Name = "تاريخ اعتماد خطاب المبررات")]
        [Required(ErrorMessage = "يجب ادخال نسبة التعديل")]
        public DateTime? AmendmentLetterApprovalDate { get; set; }

        [Display(Name = "تاريخ طلب التعديل")]
        [Required(ErrorMessage = "يجب اختيار تاريخ طلب التعديل")]
        public DateTime? AmendmentRequestDate { get; set; }

        [Display(Name = "تاريخ التوقيع من صاحب الصلاحية")]
        [Required(ErrorMessage = "يجب اختيار تاريخ التوقيع من صاحب الصلاحية")]
        public DateTime? SigntureDate { get; set; }

        [Display(Name = "تاريخ توقيع المقاول")]
        [Required(ErrorMessage = "يجب اختيار تاريخ توقيع المقاول")]
        public DateTime? ContractorSignutreDate { get; set; }


    }

}