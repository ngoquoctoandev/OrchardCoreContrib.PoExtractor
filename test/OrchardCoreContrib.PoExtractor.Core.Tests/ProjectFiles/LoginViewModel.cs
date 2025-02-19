﻿using System.ComponentModel.DataAnnotations;

namespace OrchardCoreContrib.PoExtractor.Tests.ProjectFiles;

public class LoginViewModel
{
    [Required(ErrorMessage = "The username is required.")]
    public string UserName { get; set; }

    [Required] public string Password { get; set; }
}