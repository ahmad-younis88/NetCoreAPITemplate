using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using CashVan.Common.Dto;

namespace CashVan.Common.Generic
{
    public static class CoreFunction
    {
        public static string RandomString(int length)
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public static string RandomOtp(int length)
        {
            Random random = new Random();
            const string chars = "0123456789";
            return new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public static bool SendOTP(SendOtpDto sendOtpDto)
        {
            try
            {
                var client = new HttpClient();
                client.DefaultRequestHeaders.TryAddWithoutValidation(HttpRequestHeader.Authorization.ToString(), "Bearer ecbb2a2543e4d451ba019b7c155f469f");

                string inputJson = JsonConvert.SerializeObject(sendOtpDto);
                HttpContent inputContent = new StringContent(inputJson, Encoding.UTF8, "application/json");
                HttpResponseMessage response = client.PostAsync("https://api.releans.com/v2/message", inputContent).Result;
                response.EnsureSuccessStatusCode();
                if (response.StatusCode == HttpStatusCode.OK || response.StatusCode == HttpStatusCode.Created)
                {
                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
    }
}
