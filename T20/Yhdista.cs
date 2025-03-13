using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace T20
{
    class Yhdista
    {
        private MySqlConnection yhteys = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=opiskelijat2");

        //Luodaan functio yhteyttä varten

        public MySqlConnection otaYhteys()
        { 
            return yhteys; 
        }
        // Luodaan functio yhteyden avaamista varten - HUOM! System.Data -kirjasto
        public void avaaYhteys()
        {
            if (yhteys.State == ConnectionState.Closed)
            {
                yhteys.Open();
            }
        }
        //Luodaan functio yhteyden sulkemista varten
        public void suljeYhteys()
        {
            if (yhteys.State == ConnectionState.Open)
            {
                yhteys.Close();
            }
        }
    }
}
