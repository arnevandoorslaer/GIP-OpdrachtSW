﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GIP_OpdrachtSW_ArneVandoorslaer_NickRoosen.Business;
using MySql.Data.MySqlClient;

namespace GIP_OpdrachtSW_ArneVandoorslaer_NickRoosen.Persistence
{
    public class PersistenceCode
    {
        //Dit is het aanmaken van de connectie met de databank.
        string ConnStr = "server=localhost;user id=root;password = Test123;database=dbwebshop";

        //Hier maken we een methode om alle artikels op te halen van de databank.
        public List<Artikel> GetArtikels()
        {
            MySqlConnection sqlConn = new MySqlConnection(ConnStr);
            sqlConn.Open();
            string query = "select * from tblartikel";
            MySqlCommand sqlCmd = new MySqlCommand(query, sqlConn);
            MySqlDataReader reader = sqlCmd.ExecuteReader();
            List<Artikel> lijst = new List<Artikel>();
            while (reader.Read())
            {
                Artikel _artikel = new Artikel();
                _artikel.ArtNr = Convert.ToInt32(reader["artnr"]);
                _artikel.Naam = reader["naam"].ToString();
                _artikel.Foto = reader["foto"].ToString();
                _artikel.Prijs = Convert.ToDouble(reader["prijs"]);
                _artikel.Voorraad = Convert.ToInt32(reader["voorraad"]);
                lijst.Add(_artikel);
            }
            sqlConn.Close();
            return lijst;
        }

        //Op basis van een artikelnummer wordt dit artikel opgehaald.
        public Artikel GetArtikel(int ArtNr)
        {
            MySqlConnection sqlConn = new MySqlConnection(ConnStr);
            sqlConn.Open();
            string query = "select * from tblartikel where artNr = '" + ArtNr + "'";
            MySqlCommand sqlCmd = new MySqlCommand(query, sqlConn);
            MySqlDataReader reader = sqlCmd.ExecuteReader();
            Artikel _artikel = new Artikel();
            while (reader.Read())
            {
                _artikel.ArtNr = Convert.ToInt32(reader["artnr"]);
                _artikel.Naam = reader["naam"].ToString();
                _artikel.Foto = reader["foto"].ToString();
                _artikel.Prijs = Convert.ToDouble(reader["prijs"]);
                _artikel.Voorraad = Convert.ToInt32(reader["voorraad"]);
            }
            sqlConn.Close();
            return _artikel;

        }

        //Op basis van een artikelnummer wordt de voorraad opgehaald.
        public int GetVoorraad(int ArtNr)
        {
            MySqlConnection sqlConn = new MySqlConnection(ConnStr);
            sqlConn.Open();
            string query = "select voorraad from tblartikel where artNr = '" + ArtNr + "'";
            MySqlCommand sqlCmd = new MySqlCommand(query, sqlConn);
            MySqlDataReader reader = sqlCmd.ExecuteReader();
            int voorraad = 0;
            while (reader.Read())
            {
                voorraad = Convert.ToInt32(reader["voorraad"]);
            }
            sqlConn.Close();
            return voorraad;
        }

        //Voegt een product toe aan het winkelmandje.
        public void SetMand(Winkelmand _mand)
        {
            MySqlConnection sqlConn = new MySqlConnection(ConnStr);
            sqlConn.Open();
            string query = "insert into tblwinkelmand (klantnr,artnr,aantal) values (" + _mand.KlantNr + "," + _mand.ArtNr + "," + _mand.Aantal + ")";
            MySqlCommand sqlCmd = new MySqlCommand(query, sqlConn);
            sqlCmd.ExecuteNonQuery();
            sqlConn.Close();
        }

        //Delete een product uit het winkelmandje.
        public void DeleteMand(Winkelmand _mand)
        {
            MySqlConnection sqlConn = new MySqlConnection(ConnStr);
            sqlConn.Open();
            string query = "delete from tblwinkelmand where artnr = " + _mand.ArtNr + " and klantnr = " + _mand.KlantNr;
            MySqlCommand sqlCmd = new MySqlCommand(query, sqlConn);
            sqlCmd.ExecuteNonQuery();
            sqlConn.Close();
        }

        //Haalt de gegevens op van een klant op basis van zijn ID.
        public Klant GetKlant(int KlantNr)
        {
            MySqlConnection sqlConn = new MySqlConnection(ConnStr);
            sqlConn.Open();
            string query = "select * from tblklant where klantNr = '" + KlantNr + "'";
            MySqlCommand sqlCmd = new MySqlCommand(query, sqlConn);
            MySqlDataReader reader = sqlCmd.ExecuteReader();
            Klant _klant = new Klant();
            while (reader.Read())
            {
                _klant.KlantNr = KlantNr;
                _klant.Naam = reader["naam"].ToString();
                _klant.Voornaam = reader["voornaam"].ToString();
                _klant.Adres = reader["adres"].ToString();
                _klant.PC = reader["pc"].ToString();
                _klant.Gemeente = reader["gemeente"].ToString();
                _klant.Mail = reader["mail"].ToString();
                _klant.GebrNaam = reader["gebrnaam"].ToString();
                _klant.Wachtwoord = reader["wachtwoord"].ToString();
            }
            sqlConn.Close();
            return _klant;
        }

        //Haalt een lijst op met alle items uit het winkelmandje.
        public List<WinkelmandItem> Getwinkelmanditem()
        {
            MySqlConnection sqlConn = new MySqlConnection(ConnStr);
            sqlConn.Open();
            string query = "select tblartikel.artNr,naam,prijs,foto, aantal, aantal * prijs as Totaal" + 
                           " from tblartikel inner join tblwinkelmand" +
                           " on tblartikel.artNr = tblwinkelmand.artNr";
            MySqlCommand sqlCmd = new MySqlCommand(query, sqlConn);
            MySqlDataReader reader = sqlCmd.ExecuteReader();
            List<WinkelmandItem> lijst = new List<WinkelmandItem>();
            while (reader.Read())
            {
                WinkelmandItem _wmi = new WinkelmandItem();
                _wmi.ArtNr = Convert.ToInt32(reader["artNr"]);
                _wmi.Naam = reader["naam"].ToString();
                _wmi.Foto = reader["foto"].ToString();
                _wmi.Prijs = Convert.ToDouble(reader["prijs"]);
                _wmi.Totaal = Convert.ToDouble(reader["Totaal"]);
                _wmi.Aantal = Convert.ToInt32(reader["aantal"]);
                lijst.Add(_wmi);
            }
            sqlConn.Close();
            return lijst;
        }

        //De totalen ophalen (inclusief btw, exlusief btw en het btw bedrag zelf)
        public Totalen GetTotalen()
        {
            MySqlConnection sqlConn = new MySqlConnection(ConnStr);
            sqlConn.Open();
            string query = "SELECT " +
                           "SUM(aantal * prijs) AS excl, " +
                           "SUM(aantal * prijs) * 0.21 AS btw, " +
                           "SUM(aantal * prijs) + SUM(aantal * prijs) * 0.21 AS incl " +
                           "FROM tblartikel INNER JOIN " +
                           "tblwinkelmand ON tblartikel.artNr = tblwinkelmand.artNr ";

            MySqlCommand sqlCmd = new MySqlCommand(query, sqlConn);
            MySqlDataReader reader = sqlCmd.ExecuteReader();
            Totalen _totaal = new Totalen();
            while (reader.Read())
            {
                _totaal.Incl = Convert.ToDouble(reader["incl"]);
                _totaal.BTW = Convert.ToDouble(reader["btw"]);
                _totaal.Excl = Convert.ToDouble(reader["excl"]);
            }
            sqlConn.Close();
            return _totaal;
        }

        //Na het verwijderen van een artikel uit het winkelmandje wordt de voorraad openieuw toegevoegd in de database.
        public void SetVoorraad(int ArtNr,int Aantal)
        {
            MySqlConnection sqlConn = new MySqlConnection(ConnStr);
            sqlConn.Open();
            string query = "UPDATE tblartikel SET voorraad = voorraad + " + Aantal + " where ArtNr = " + ArtNr;
            MySqlCommand sqlCmd = new MySqlCommand(query, sqlConn);
            sqlCmd.ExecuteNonQuery();
            sqlConn.Close();
        }

        //Controleer of een artikel al in de winkelmand zit
        public bool CheckMand(int KlantNr, int ArtNr)
        {
            MySqlConnection sqlConn = new MySqlConnection(ConnStr);
            sqlConn.Open();
            string query = "SELECT * FROM tblwinkelmand WHERE klantNr IN (" + KlantNr + ") AND artNr IN(" + ArtNr + ")";
            MySqlCommand sqlCmd = new MySqlCommand(query, sqlConn);
            MySqlDataReader reader = sqlCmd.ExecuteReader();
            int klantnr = 0;
            int artnr = 0;
            while (reader.Read())
            {
                artnr = Convert.ToInt32(reader["artnr"]);
                klantnr = Convert.ToInt32(reader["klantnr"]);
            }
            sqlConn.Close();
            if(klantnr != 0 || artnr != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Een order wordt opgesteld.
        public void maakOrder(int KlantNr, DateTime orderDatum)
        {
            MySqlConnection sqlConn = new MySqlConnection(ConnStr);
            sqlConn.Open();
            string query = "insert into tblbestelling (klantnr,orderdatum) values (" + KlantNr + ",'"  + orderDatum.ToString("yyyy-MM-dd") + "')";
            MySqlCommand sqlCmd = new MySqlCommand(query, sqlConn);
            sqlCmd.ExecuteNonQuery();
            sqlConn.Close();
        }
        
        //Haal orderID op.
        public int getOrderNr(int KlantNr)
        {
            MySqlConnection sqlConn = new MySqlConnection(ConnStr);
            sqlConn.Open();
            string query = "select ordernr from tblbestelling where klantnr =" + KlantNr;
            MySqlCommand sqlCmd = new MySqlCommand(query, sqlConn);
            MySqlDataReader reader = sqlCmd.ExecuteReader();
            int OrderID = 0;
            while (reader.Read())
            {
                OrderID = Convert.ToInt32(reader["OrderNr"]);
            }
            sqlConn.Close();
            return OrderID;
        }

        //Sla bestellijn op.
        public void saveBestelling(int OrderNr, int ArtNr,int Aantal, double Prijs)
        {
            MySqlConnection sqlConn = new MySqlConnection(ConnStr);
            sqlConn.Open();
            string query = "insert into tblbestellijn (OrderNr,ArtNr,Aantal,prijs) values (" + OrderNr + "," + ArtNr + "," + Aantal + "," + Prijs.ToString().Replace(',','.') + ")";
            MySqlCommand sqlCmd = new MySqlCommand(query, sqlConn);
            sqlCmd.ExecuteNonQuery();
            sqlConn.Close();
        }

    }
}