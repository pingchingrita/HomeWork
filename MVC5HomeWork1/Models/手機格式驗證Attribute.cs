using System;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace MVC5HomeWork1.Models
{
    internal class 手機格式驗證Attribute : DataTypeAttribute
    {

        //實作一個「自訂輸入驗證屬性」可驗證「手機」的電話格式必須為 "\d{4}-\d{6}" 的格式 ( e.g. 0911-111111 )
        public 手機格式驗證Attribute():base(DataType.Text)
        {

        }

        public override bool IsValid(object value)
        {
            var str = (string)value;

            Regex regex = new Regex(@"\d{4}-\d{6}");
            
            return regex.IsMatch(str);
        }

    }
}