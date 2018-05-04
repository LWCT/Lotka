using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Animal;
namespace Lotka
{
   
    //关系

    public enum RelativeshipKind {Prey,Dependency ,Competition};
    public class Relativeship
    {
        protected Animal.Animal animalOne;
        protected Animal.Animal animalTwo;

        protected RelativeshipKind relativeshipKind;

        protected Relativeship(Animal.Animal animalOne,Animal.Animal animalTwo)
        {
            this.animalOne = animalOne;
            this.animalTwo = animalTwo;
        }

        public virtual void UpdateCount()
        {

        }
    }
    /*
     *猎食关系
     */ 
     public class Prey : Relativeship
    {
        //继承的animalOne 这里看作猎物,如兔
        //继承的animalTwo 这里看作猎食者,如浪
        
        //参数
        public float a;
        public float p;
        public float d;
        public float r;
        public Prey(Animal.Animal animalOne, Animal.Animal animalTwo,float a ,float p ,float d,float r) : base(animalOne, animalTwo)
        {
            base.relativeshipKind = RelativeshipKind.Prey;
            this.a = a;
            this.p = p;
            this.d = d;
            this.r = r;
        }
        //更新操作
        override public void UpdateCount()
        {
            base.animalOne.Engry = base.animalOne.Engry + (a * base.animalOne.Count - p * base.animalOne.Count * base.animalTwo.Count);
            base.animalTwo.Engry = base.animalTwo.Engry + (d * base.animalOne.Count * base.animalTwo.Count - r * base.animalTwo.Count);
        }
    }
    /*
     *依存关系 
     */
    public class Dependency :Relativeship 
    {

        //系数

        public Dependency(Animal.Animal animalOne, Animal.Animal animalTwo) : base(animalOne, animalTwo)
        {
            
            base.relativeshipKind = RelativeshipKind.Dependency;
        }
        //更新操作
        override public void UpdateCount()
        {
            
        }
    }
    /*
     * 竞争关系
     */
    public class Competition:Relativeship
    {
        //系数
        public Competition(Animal.Animal animalOne, Animal.Animal animalTwo) : base(animalOne, animalTwo)
        {
            base.relativeshipKind = RelativeshipKind.Competition;
        }
        //更新操作
        override public void UpdateCount()
        {
            
        }
    }
    
}
