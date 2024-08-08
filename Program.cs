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
            porcheBuilder.SetEngine("3.6L 6기통");
            porcheBuilder.SetHorsePower("388 to 478 hp");
            porcheBuilder.SetTransmission("7 & 8-speed automatic");
            porcheBuilder.SetZeroSixty(3.50d);
            Car car0 = porcheBuilder.Build();
            Console.WriteLine($"{car0.year} {car0.brand} {car0.name}, 가격:${car0.price}, 엔진:{car0.engine}, 마력:{car0.horsePower}, 변속기:{car0.transmission}, 제로백:{car0.zeroSixty}");


            CarBuilder lamboBuilder = new CarBuilder();
            lamboBuilder.SetYear(2024).SetBrand("Lamborghini").SetName("Huracan").SetPrice(249685).SetEngine("5.2 L V10").SetHorsePower("640 hp").SetTransmission("7-speed automatic").SetZeroSixty(2.90d);
            CarBuilder genesisBuilder = new CarBuilder();
            genesisBuilder.SetYear(2024).SetBrand("Genesis").SetName("GV80").SetPrice(64850).SetEngine("3.5 L V6").SetHorsePower("300 to 375 hp").SetTransmission("8-speed automatic").SetZeroSixty(6.10d);
            CarBuilder bmwBuilder = new CarBuilder();
            bmwBuilder.SetYear(2024).SetBrand("BMW").SetName("M4").SetPrice(78100).SetEngine("3.0 L 6기통").SetHorsePower("473 to 503 hp").SetTransmission("8-speed automatic").SetZeroSixty(3.80d);
            CarBuilder mercedesBuilder = new CarBuilder();
            mercedesBuilder.SetYear(2024).SetBrand("Mercedes-Benz").SetName("AMG GT").SetPrice(134900).SetEngine("4.0 L V8").SetHorsePower("577 hp").SetTransmission("9-speed automatic").SetZeroSixty(3.10d);
            CarBuilder mcLarenBuilder = new CarBuilder();
            mcLarenBuilder.SetYear(2024).SetBrand("McLaren").SetName("750S").SetPrice(324000).SetEngine("4.0 L V8").SetHorsePower("740 hp").SetTransmission("7-speed automatic").SetZeroSixty(2.70d);


            Car[] cars = new Car[5];
            cars[0] = lamboBuilder.Build();
            cars[1] = genesisBuilder.Build();
            cars[2] = bmwBuilder.Build();
            cars[3] = mercedesBuilder.Build();
            cars[4] = mcLarenBuilder.Build();

            for (int i = 0; i < cars.Length; i++)
            {
                //Console.WriteLine($"{i}번 자동차: ");
                Console.WriteLine($"{cars[i].year} {cars[i].brand} {cars[i].name}, 가격:${cars[i].price}, 엔진:{cars[i].engine}, 마력:{cars[i].horsePower}, 변속기:{cars[i].transmission}, 제로백:{cars[i].zeroSixty}");
            }



        }
    }


}
