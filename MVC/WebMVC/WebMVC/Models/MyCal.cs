using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebMVC.Models
{
    public class MyCal
    {
        public int GetAvg(int score,int subject)
        {
            return score / subject;
        }
    }
}