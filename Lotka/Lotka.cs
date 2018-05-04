using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Animal;
namespace Lotka
{
    public class Lokta
    {
        public float timeStep;
        private DateTime latsTime = DateTime.Now;

        List<Relativeship> relativeships = new List<Relativeship>();
        public Lokta(float timeStep)
        {

        }
        public void UpdateCount()
        {
            if ((DateTime.Now - latsTime).TotalSeconds >= timeStep)
            { 
                foreach(var r in relativeships)
                {
                    r.UpdateCount();
                }
            }
        }
        public void AddRelativeship(Relativeship relativeship)
        {
            relativeships.Add(relativeship);
        }
        
    }


}