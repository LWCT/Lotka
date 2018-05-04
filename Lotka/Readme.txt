Relativeship命名空间:为各种种群关系
Animal命名空间:为各种群类型
Lotka命名空间:统一调控各Rlativeship

======
2018.5.4 
实现的功能:实现洛特卡－沃尔泰拉方程
存在的问题:存在一方消亡的情况

Lotka类使用方式

~~~ccharp
Lokta myLokta = new Lokta(0.1f);//传入更新Relativeship两端的生物的数量的时间间隔
Animal.Animal animalOne = new Animal.Animal(4000);//声明生物one 4000只
Animal.Animal animalTwo = new Animal.Animal(100);//声明生物one 100只

//使用Prey 联系上面的两个生物对象,传入生物对象,以及pery关系的参数
//Prey使用洛特卡－沃尔泰拉方程（Lotka-Volterra equation）实现
//https://zh.wikipedia.org/wiki/%E6%B4%9B%E7%89%B9%E5%8D%A1%EF%BC%8D%E6%B2%83%E7%88%BE%E6%B3%B0%E6%8B%89%E6%96%B9%E7%A8%8B
Relativeship.Relativeship relativeship = new Prey(animalOne,animalTwo,0.1f,0.002f,0.00002f,0.1f);
//在Lokta中登记这个Relativeship
myLokta.AddRelativeship(relativeship);

//反复调用更新
while (true)
            {
                myLokta.UpdateCount();          
            }

~~~