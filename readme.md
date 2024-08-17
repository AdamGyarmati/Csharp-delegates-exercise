## Feladat: Egyszerű számológép delegáltakkal <br>
Készíts egy C# konzol alkalmazást, amely egy egyszerű számológép funkciót valósít meg. A programnak lehetőséget kell adnia a felhasználónak arra, hogy különböző műveleteket végezzen két szám között (összeadás, kivonás, szorzás, osztás). A műveletek végrehajtását delegáltak segítségével kell megvalósítani.

Feladat részletei:
1. Létrehozás:

* Hozz létre egy Calculator nevű osztályt. <br>
* Az osztály tartalmazzon egy Calculate nevű metódust, amely egy delegáltat fogad paraméterként. A metódusnak két double típusú számot kell fogadnia, és vissza kell adnia a delegált által végrehajtott művelet eredményét.

2. Delegált létrehozása:

* Hozz létre egy MathOperation nevű delegáltat, amely két double típusú paramétert fogad és egy double értéket ad vissza.

3. Alapműveletek:

* Implementálj négy statikus metódust a Calculator osztályban: Add, Subtract, Multiply, és Divide, amelyek mindegyike a megfelelő matematikai műveletet hajtja végre két szám között.

4. Felhasználói interakció:

* A Main metódusban kérdezd meg a felhasználótól, hogy melyik műveletet szeretné elvégezni, és melyik két számmal szeretne dolgozni. <br>
* A felhasználó választásától függően hozz létre egy delegáltat, amely az adott műveletet végzi, és hívd meg a Calculate metódust a megfelelő paraméterekkel.

5. Kimenet:

* A program írja ki az eredményt a konzolra.

**Példa:** <br>
A program futása során a következő interakció zajlik le:

```
Válassza ki a műveletet:
1. Összeadás
2. Kivonás
3. Szorzás
4. Osztás

Kérem a választást: 1
Kérem az első számot: 10
Kérem a második számot: 5

Az eredmény: 15
```