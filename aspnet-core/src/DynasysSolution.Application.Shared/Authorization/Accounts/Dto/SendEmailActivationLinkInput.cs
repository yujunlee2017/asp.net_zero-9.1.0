﻿using System.ComponentModel.DataAnnotations;

namespace DynasysSolution.Authorization.Accounts.Dto
{
    public class SendEmailActivationLinkInput
    {
        [Required]
        public string EmailAddress { get; set; }
    }
}