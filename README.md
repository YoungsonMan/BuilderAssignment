# 디자인패턴 과제2: 빌더패턴 활용하기

---

이번 강의에선 빌더패턴의 예시로, 게임에 필요한 오브젝트를 생성하는 코드를 다루었었습니다. 

해당 개념을 참고하여, 원하는 Builder클래스를 만들고, 빌더를 통해서 다양한 객체를 생성해봅니다. 

아래는 예시입니다. 예시를 참고하여 원하는 Builder를 만들어 보세요.

### Goal 학습목표

---

- MonsterBuilder 클래스를 만들어 몬스터의 이름, 외형, 전리품, 경험치, 공격범위, 전투스타일 등을 조합하여 여러 유형의 Monster들을 만들 수 있습니다.
- AnimalBuilder 클래스를 만들어 동물의 이름, 외형, 생산품, 울음소리, 사료종류, 등을 조합하여 여러 유형의 Animal들을 만들 수 있습니다.
- ItemType은 열거형으로 Potion, Weapon, Armor, Food 항목을 가진다
- UnitBuilder 클래스를 만들어 유닛의 이름, 이동방법, 공격타입, 방어타입, 생산가격 등을 조합하여 여러 유형의 Unit들을 만들 수 있습니다.


### Built with

---

Visual Studio 2022 v17.10.3

Laguage used - C#

### Explanation

---

무엇을 만들 수 있을까 고민고민 하다가, 그나마 뭔가 심플한거 같은 자동차를 만들어보기로 하였습니다.


가독성을 위해서 클래스파일을 따로 빼서 작성.

![BuilderPattern01](https://github.com/user-attachments/assets/4c1782c8-b17e-4dfd-ac34-b6e0a83b1684)

![BuilderPattern00](https://github.com/user-attachments/assets/dab8bdd4-c848-424e-96c5-d62e271c33ca)

24-08-09 업데이트

![BuilderPattern11](https://github.com/user-attachments/assets/4f8887be-5cc2-4637-b918-81ddfc54853f)




## Comments

---

개인적으로 빌더패턴을 이용하는 것 또한 가독성, 디자인, 편의성, 이해도 부분에서 팩토리 패턴처럼 정형화된 패턴을  사용해서 작성을 하는게 훨씬 수월하였다.

좋다22...

그렇지만 마지막 부분에 프린트 하는 과정에 Array에 forloop에서 \t을 써서 string들을 띄었는데 문자열들이 길이가 다 달라서 오히려 더 이쁘게 프린트가 되지 않았다. 

어떻게 이쁘게 정렬이 되어서 출력할 수 있을까.

24-08-09 업데이트

문자열 보간 

밑에처럼 ',' 코마 문자 띄울만큼 입력해서 \t말고 다르게 띄어 쓸 수 있다. 
```
Console.WriteLine($"{cars[i].year} {cars[i].brand,14} {cars[i].name,10}, 가격:${cars[i].price,10}, 엔진:{cars[i].engine,10}, 마력:{cars[i].horsePower,14}, 변속기:{cars[i].transmission,22}, 제로백:{cars[i].zeroSixty,6}");
```
