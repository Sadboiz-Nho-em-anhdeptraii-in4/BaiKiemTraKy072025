using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebMVC.Models;
namespace WebMVC.Controllers;

public class StudentController
{

    public string? hoTen { get; set;}
    public float tuoi { get; set; }
    [Key]
    public int maSv { get; set; }

}
