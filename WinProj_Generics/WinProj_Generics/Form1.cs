using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections; //add this to use example


namespace WinProj_Generics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Car> list = new List<Car>();
            Car c = new Car(1, "Porche");
            list.Add(c);
            c = new Car(2, "Ford");
            list.Add(c);
            c = new Car(3, "Toyota");
            list.Add(c);
            c = new Car(4, "No Brand");
            list.Insert(1, c); //插入到1的index下方
            for (int i = 0; i < list.Count; i++)
                Console.WriteLine(list[i]);
            Console.WriteLine("=====================");

            Car c1 = list[1];
            list.Remove(c1); //No Brand會被刪除掉

            c1 = list[2];
            c1.Name = "YunLoong"; //把index2也就是Toyota改成YunLoong

            //list<Car>的好處 之前內部foreach(object obj in list)
            foreach (Car obj in list) //不用之前一樣用obj在轉型 直接用class Car就可以撈出來
                Console.WriteLine(obj);
            /*
                NO: 1	Model: Porche
                NO: 4	Model: No Brand
                NO: 2	Model: Ford
                NO: 3	Model: Toyota
                =====================
                NO: 1	Model: Porche
                NO: 2	Model: Ford
                NO: 3	Model: YunLoong
             */

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dictionary<string, Car> ht = new Dictionary<string, Car>();
            Car c = new Car(1, "Porche");
            ht.Add("PORCHE", c);
            c = new Car(2, "Ford");
            ht.Add("FORD", c);
            c = new Car(3, "Toyota");
            ht.Add("TOYOTA", c); ;
            c = new Car(4, "No Brand");
            ht.Add("NA", c); ;

            //KeyValuePair<string,Car> 可以取代之前在裡面的DictionaryEntry
            foreach (KeyValuePair<string,Car> entry in ht)
            {
                Console.WriteLine("Key:{0}\tValue:{1}", entry.Key, entry.Value);
            }
            //key is index ,value is 內容
            foreach (string k in ht.Keys)
            {
                Console.WriteLine("{0},", ht[k]);
            }
            ht.Remove("NA");
            Car v = (Car)ht["FORD"];
            v.Name = "YueLoong";
            foreach (KeyValuePair<string, Car> entry in ht)
            {
                Console.WriteLine("Key:{0}\tValue:{1}", entry.Key, entry.Value);
            }

            /*Result
               
                Key:PORCHE	Value:NO: 1	Model: Porche
                Key:FORD	Value:NO: 2	Model: Ford
                Key:TOYOTA	Value:NO: 3	Model: Toyota
                Key:NA	Value:NO: 4	Model: No Brand
                NO: 1	Model: Porche,
                NO: 2	Model: Ford,
                NO: 3	Model: Toyota,
                NO: 4	Model: No Brand,
                Key:PORCHE	Value:NO: 1	Model: Porche
                Key:FORD	Value:NO: 2	Model: YueLoong
                Key:TOYOTA	Value:NO: 3	Model: Toyota
             */
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //靠key值英文字母從小先排
            SortedList<string, Car> ht = new SortedList<string, Car>();
            Car c = new Car(1, "Porche");
            ht.Add("PORCHE", c);
            c = new Car(2, "Ford");
            ht.Add("FORD", c);
            c = new Car(3, "Toyota");
            ht.Add("TOYOTA", c); ;
            c = new Car(4, "No Brand");
            ht.Add("NA", c); ;

            //KeyValuePair<string,Car> 可以取代之前在裡面的DictionaryEntry
            foreach (KeyValuePair<string, Car> entry in ht)
            {
                Console.WriteLine("Key:{0}\tValue:{1}", entry.Key, entry.Value);
            }
            //key is index ,value is 內容
            foreach (string k in ht.Keys)
            {
                Console.WriteLine("{0},", ht[k]);
            }
            ht.Remove("NA");
            Car v = (Car)ht["FORD"];
            v.Name = "YueLoong";
            foreach (KeyValuePair<string, Car> entry in ht)
            {
                Console.WriteLine("Key:{0}\tValue:{1}", entry.Key, entry.Value);
            }
            /*  Result
                Key:FORD	Value:NO: 2	Model: Ford
                Key:NA	Value:NO: 4	Model: No Brand
                Key:PORCHE	Value:NO: 1	Model: Porche
                Key:TOYOTA	Value:NO: 3	Model: Toyota
                NO: 2	Model: Ford,
                NO: 4	Model: No Brand,
                NO: 1	Model: Porche,
                NO: 3	Model: Toyota,
                Key:FORD	Value:NO: 2	Model: YueLoong
                Key:PORCHE	Value:NO: 1	Model: Porche
                Key:TOYOTA	Value:NO: 3	Model: Toyota
             */
        }
    }
}
