using System;
using Microsoft.AspNetCore.Http;

namespace DatingApp.API.Helpers
{
    public static class Extensions
    {
        public static void AddApplicationError( this HttpResponse responce, string message)
        {
           responce.Headers.Add("Application-Error", message);
           responce.Headers.Add("Access-Control-Expose-Headers", "Application Error");
           responce.Headers.Add("Access-Control-Allow-Origin", "*");
        }


        public static int CalculateAge(this DateTime theDateTime)
        {
            var age = DateTime.Today.Year - theDateTime.Year;

            if(theDateTime.AddYears(age) > DateTime.Today)
            age--;

            return age;
        }
    }
}