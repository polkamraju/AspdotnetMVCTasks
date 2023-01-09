using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using AspDotnetMVCTask4.Helper;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AspDotnetMVCTask4.Models
{
    public class UserModel
    {
        //[Key, Column(Order = 1)]
        //[DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        //public int UserId { get; set; }


        [Required(ErrorMessage = "User Name is Required.")]
        [StringLength(50, MinimumLength = 3)]
        public string UserName { get; set; }



        [Required(ErrorMessage = "Credit Card / Mode of Payment Selection is Required.")]
        public string CreditCardSelected { get; set; }

 

        [Required(ErrorMessage = "Credit Card Number is Required.")]
        //[DataType(DataType.CreditCard)]
        [Helper.CreditCard(AcceptedCardTypes = Helper.CreditCardAttribute.CardType.Visa | Helper.CreditCardAttribute.CardType.MasterCard)]
        public string CreditCardNumber { get; set; }

        //[NotMapped]
        //public SelectList ModeOfPayment { get; set; }



    }
}
