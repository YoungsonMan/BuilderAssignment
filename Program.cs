namespace BuilderAssignment
{/**************************************************************************
 * 디자인패턴 과제
 * YC
 * 과제 2. 빌더패턴 활용하기
 * 원하는 Builder Class를 만들고, 빌더를 통해서 다양한 객체를 생성해보기
 * 예시: 
 *      MonsterBuilder Class를 만들어 몬스터의 이름, 외형, 전리품, 공격범위, 전투스타일 등을 조합하여 여러유형의 몬스터를 만든다.
 *      AnimalBuilder Class를 만들어 동물의 이름, 외형, 생산품, 울음소리, 사료종류 등을 조합하여 여러 유형의 동물들을 만든다.
 *      UnitBuilder Class를 유닛의 이름, 이동방법, 공격타입, 방어타입, 생산가격 등을 조합하여 여러 유형의 유닛들을 만들수 있다.
 **************************************************************************/
    public class Program
    {
        static void Main(string[] args)
        {
            CarBuilder porcheBuilder = new CarBuilder();
            porcheBuilder.SetYear(2024);
            porcheBuilder.SetBrand("Porche");
            porcheBuilder.SetName("911");
            porcheBuilder.SetPrice(114400);
            porcheBuilder.SetEngine("3.6 L 6-cylinder");
            porcheBuilder.SetHorsePower("388 to 478 hp");
            porcheBuilder.SetTransmission("7 & 8-speed automatic");
            porcheBuilder.SetZeroSixty(3.50d);
            Car car0 = porcheBuilder.Build();
            Console.WriteLine($"{car0.year}{car0.brand} {car0.name}\t가격:${car0.price}\t엔진:{car0.engine}\t마력:{car0.horsePower}\t변속기:{car0.transmission}\t제로백:{car0.zeroSixty}");


            CarBuilder lamboBuilder = new CarBuilder();
            lamboBuilder.SetYear(2024).SetBrand("Lamborghini").SetName("Huracan").SetPrice(249685).SetEngine("5.2 L V10").SetHorsePower("640 hp").SetTransmission("7-speed automatic").SetZeroSixty(2.90d);



            Car[] cars = new Car[4];




        }
    }
    
    
}
