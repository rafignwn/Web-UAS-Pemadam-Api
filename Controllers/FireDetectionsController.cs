using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Web_UAS.Models;
using MySql.Data.MySqlClient;

namespace Web_UAS.Controllers
{
    public class FireDetectionsController : Controller
    {
        private readonly ILogger<FireDetectionsController> _logger;

        public FireDetectionsController(ILogger<FireDetectionsController> logger){
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index(){
            return View();
        }

        [HttpGet("setFireValue/{api}")]
        public IActionResult setFireValue(string api){
            // mengambil waktu sekarang jika terdeteksi adanya api
            if( (api == "0" && DeteksiApi.staticFireValue == "1") || (api == "0" && DeteksiApi.staticFireValue == null)){
                DateTime now = DateTime.Now;
                DeteksiApi.tanggal = now.ToString("dd/MM/yyyy");
                DeteksiApi.jam = now.ToString("HH:mm:ss");

                // insert data jam dan tanggal
                MySqlConnection conn = new MySqlConnection{
                    ConnectionString = Startup.ConnectionString
                };
                // membuka koneksi ke database
                conn.Open();

                // membuat query Insert data
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO table_fire (jam, tanggal) VALUES (?jam, ?tanggal)";

                // mengisi parameter
                cmd.Parameters.AddWithValue("?jam", DeteksiApi.jam);
                cmd.Parameters.AddWithValue("?tanggal", DeteksiApi.tanggal);

                // eksekusi query
                cmd.ExecuteNonQuery();

                // menutup koneksi
                conn.Close();
            }

            // mengambil nilai api
            DeteksiApi.staticFireValue = api;

            return Ok("Nilai Api = " + api);
        }

        [HttpGet]
        public IActionResult Kondisi(){
            return View();
        }

        [HttpGet("RecordsFire")]
        public IActionResult RecordsFire(){
            IList<Fire> records = new List<Fire>();

            //mengambil Connection string 
            MySqlConnection conn = new MySqlConnection{
                ConnectionString = Startup.ConnectionString
            };
            // membuka koneksi database
            conn.Open();

            // mengambil semua data di table_fire
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM table_fire;", conn);
            // eksekusi query
            MySqlDataReader dataReader = cmd.ExecuteReader();
            // mengambil data
            while(dataReader.Read()){
                Fire item = new Fire();
                item.jam = Convert.ToString(dataReader["jam"]);
                item.tanggal = Convert.ToString(dataReader["tanggal"]);

                //menampung data ke records
                records.Add(item);
            }
            dataReader.Close();
            conn.Close();

            return View(records);
        }
    }
}