using System.Collections.Generic;

public class Base
{
    public string[] fields {get; set;}
    public string[] degrees {get; set;}
    public string[] states {get; set;}
    public string[] situations {get; set;}

    public Base()
    {
        fields = new string[]{"مهندسی" , "حقوق" , "خدمات" ,
                "فنی" , "هنری" , "ادبی" , "تدریس" };

        degrees = new string[]{"کاردانی" ,"دیپلم", "کارشناسی" , "کارشناسی- ارشد"
         , "دکتری"};

        states = new string[]{"تهران" , "اصفهان" , "فارس" , "مرکزی " , "خراسان رضوی" , "سیستان و بلوچستان"
        , "یزد" , "گلستان"};

        situations = new string[]{"در حال استخدام" };
    }
}