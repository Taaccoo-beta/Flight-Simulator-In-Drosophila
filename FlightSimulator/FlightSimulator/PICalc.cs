using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightSimulator
{
    class PICalc
    {
        private List<List<float>> position = new List<List<float>>();
        private List<List<float>> troque = new List<List<float>>();
        private List<float> PIValue = new List<float>();
        public PICalc(List<List<float>> position, List<List<float>> troque)
        {
            this.position = position;
            this.troque = troque;

        }

        public List<float> getPIValue()
        {

            for (int i = 0; i != position.Count; i++)
            {
                ;
            }
            return new List<float>();
        }


        private float CalcPI(List<float> p)
        {
            return 0f;
        }

    }
}
