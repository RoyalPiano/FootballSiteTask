using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FootballSiteTask.Data.Models
{
    public enum Country
    {
        Russia,
        USA,
        Italy
    }

    public static class ListOfCountries
    {
        static public List<Country> Countries = new List<Country>{ Country.Russia, Country.USA, Country.Italy };
    }
}
