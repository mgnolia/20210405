﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Managing_Car_Program
{
    class Datamanger
    {
        public static List<ParkingCar> Cars = new List<ParkingCar>();
        static Datamanger()
        {
            Load();
        }
        public static void Load()
        {
            /*
               <parkingSpot>1</parkingSpot>
  <carNumber>30고9484</carNumber>
  <driverName>이동준</driverName>
  <phoneNumber>010-2940-1613</phoneNumber>
  <parkingTime>2021-04-16 오전 11:40:58</parkingTime>

             */
            Cars.Clear(); 
            try
            {
                string carsOutput = File.ReadAllText(@"./Cars.xml");
                XElement carsXElement = XElement.Parse(carsOutput);
                foreach (var item in carsXElement.Descendants("car"))
                {
                    int tempParkingSpot = int.Parse(item.Element("parkingSpot").Value);
                    string tempCarNumber = item.Element("carNumber").Value;
                    string tempDriverName = item.Element("driverName").Value;
                    string tempPhoneNumber = item.Element("phoneNumber").Value;
                    DateTime tempParkingTime = item.Element("parkingTime").Value == "" ? 
                        DateTime.Now : DateTime.Parse(item.Element("parkingTime").Value);

                    ParkingCar tempCar = new ParkingCar()
                    {
                        parkingSpot = tempParkingSpot,
                        carNumber = tempCarNumber,
                        driverName = tempDriverName,
                        phoneNumber = tempPhoneNumber,
                        parkingTime = tempParkingTime
                    };
                    Cars.Add(tempCar);
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                printLog(ex.Message);
                printLog(ex.StackTrace);
                CreateFile();//파일을 다시 만들고
                Save();//그 파일을 저장한다음
                Load();//다시 불러들여본다.
                       //단 Load 함수 자체가 잘못된거라면 이 코드는 무한루프에 빠진다.
                       //example();
            }

        }
        private void example()
        { }

        private static void CreateFile()
        {
            //cars.xml파일을 만들겁니다
            string fileName = @"./Cars.xml";
            StreamWriter writer = File.CreateText(fileName);
            writer.Dispose(); //메모리 삭제
        }
        public static void Save()
        {
            string booksOutput ="";
            booksOutput += "<cars>\n";
            if (Cars.Count > 0)
            {
                foreach (var item in Cars)
                {
                    booksOutput += "<car>\n";
                    booksOutput += $"   <parkingSpot>{item.parkingSpot}</parkingSpot>\n";
                    booksOutput += $"   <carNumber>{item.carNumber}</carNumber>\n";
                    booksOutput += $"   <driverName>{item.driverName}</driverName>\n";
                    booksOutput += $"   <phoneNumber>{item.phoneNumber}</phoneNumber>\n";
                    booksOutput += $"   <parkingTime>{item.parkingTime}</parkingTime>\n";
                    booksOutput += "</car>\n";

                }

            }
            else
            {
                for (int i = 1; i <= 5; i++)
                {
                    booksOutput += "<car>\n";
                    booksOutput += $"   <parkingSpot>{i}</parkingSpot>\n";
                    booksOutput += $"   <carNumber></carNumber>\n";
                    booksOutput += $"   <driverName></driverName>\n";
                    booksOutput += $"   <phoneNumber></phoneNumber>\n";
                    booksOutput += $"   <parkingTime></parkingTime>\n";
                    booksOutput += "</car>\n";

                }

            }
            booksOutput += "</cars>";
            File.WriteAllText(@"./Cars.xml", booksOutput);
        }
        //두번째 파라미터를 넣지 않으면 name에는 parkingHistory가 들어감
        public static void printLog(string contents, string name= "parkingHistory")
        {
            string directory = "parkingHistory";
            DirectoryInfo di = new DirectoryInfo(directory);
            //if(di.Exists == false)
            if(!di.Exists)
            {
                di.Create(); // 폴더 만들기
            }
            //앞에 @가 있으면
            // \ 를 한 개만 적는다.
            // @가 없으면 \\ 이렇게 해야지 1개로 인식함
            //using (StreamWriter writer = new StreamWriter(@"parkingHistory\parkingHistory.txt", true))
            using (StreamWriter writer = new StreamWriter(directory+@"\"+name+".txt",true))
            {
                writer.WriteLine(contents);
            }
        }
    }
}
