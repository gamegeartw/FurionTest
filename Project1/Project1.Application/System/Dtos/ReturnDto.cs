namespace Project1.Application;

public class ReturnDto
{
    [Required(ErrorMessage = "必填"), MinLength(3, ErrorMessage = "字符串长度不能少于3位")]
    public string Data { get; set; }

    [Required,Range(1,10)]
    public int InputCode { get; set; }
}