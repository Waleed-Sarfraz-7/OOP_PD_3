using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_self_task_1
{
    internal class Transcations
    {
        public string TranscationId;
        public double ProductName;
        public float ProductPrice;
        public string TranscationDate;
        public string TranscationTime;
        public Transcations()
        {

        }
        public Transcations(Transcations Transcation)
        {
          TranscationId=Transcation.TranscationId;
          ProdNo=Transcation.ProductName;
          ProductPrice=Transcation.ProductPrice;


        }

    }
}
