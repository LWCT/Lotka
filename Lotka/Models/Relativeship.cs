using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Animal;
namespace Relativeship
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
        /*
         *更新操作
         *使用洛特卡－沃尔泰拉方程实现数量变化
         *维基百科链接:https://zh.wikipedia.org/wiki/%E6%B4%9B%E7%89%B9%E5%8D%A1%EF%BC%8D%E6%B2%83%E7%88%BE%E6%B3%B0%E6%8B%89%E6%96%B9%E7%A8%8B
         */
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
