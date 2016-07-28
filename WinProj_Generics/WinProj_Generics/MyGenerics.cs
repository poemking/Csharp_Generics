using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections; //add this to use example

namespace WinProj_Generics
{
    class MyGenerics
    {
    }
    public class Car
    {
        int _no;
        string _model;

        //建構子
        public Car(int _no, string _model)
        {
            this._no = _no;
            this._model = _model;
        }

        public override string ToString()
        {
            return "NO: " + _no + "\tModel: " + _model;
        }
        public string Name
        {
            set { _model = value; }
        }
    }
}
