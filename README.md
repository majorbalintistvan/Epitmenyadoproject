
# 4. Építményadó
Egy Balaton-parti önkormányzat építményadót vezet be. Az adó mértéke a telken lévő 
építmény alapterületétől és a teleknek a Balatontól mért távolságától függ. 
A telkeket a Balatonparttól mért távolságtól függően három sávba sorolták be. Az A sávba 
azok a telkek kerültek, amelyek 300 méternél közelebb vannak a tóhoz a B sáv az előzőn túl 
600 méter távolságig terjed, a többi telek a C sávba tartozik. Az építmény után 
négyzetméterenként fizetendő összeg sávonként eltérő, azonban, ha az így kiszámított összeg 
nem éri el a 10.000 Ft-ot, akkor az adott építmény után nem kell adót fizetni. 

--- 
A testületi döntést az Adó Ügyosztály egy mintával készítette elő, amely csupán néhány utca 
adatait tartalmazza. Ezek az adatok az `utca.json` fájlban vannak. A fájl első sorában a három 
adósávhoz tartozó négyzetméterenként fizetendő összeg található A, B, C sorrendben, egy-egy 
szóközzel elválasztva: 
```
800 600 100   
…  
33366 Aradi 8A C 180  
22510 Aradi 8B C 137  
90561 Aradi 10 C 168  
… 
```
---
A többi sorban egy-egy építmény adatai szerepelnek egy-egy szóközzel elválasztva. Az első 
a telek tulajdonosának ötjegyű adószáma; egy tulajdonosnak több telke is lehet. A második adat 
az utca neve, amely nem tartalmazhat szóközt. A harmadik adat a házszám, majd az adósáv 
megnevezése, végül az építmény alapterülete következik. A minta harmadik sorában például 
azt látjuk, hogy a 33366 adószámú tulajdonos telke az Aradi utca 8A-ban található, és a C sávba 
eső telken álló építmény alapterülete 180 m^2^.

---
A fájl legfeljebb 1000 telek adatait tartalmazza. A feladat megoldása során kihasználhatja, 
hogy a fájlban az adatok utca, azon belül pedig házszám szerinti sorrendben következnek.
Készítsen programot, amely az `utca.json` állomány adatait felhasználva az alábbi 
kérdésekre válaszol! A program forráskódját mentse epitmenyado néven! (A program 
megírásakor a felhasználó által megadott adatok helyességét, érvényességét nem kell 
ellenőriznie, és feltételezheti, hogy a rendelkezésre álló adatok a leírtaknak megfelelnek.) 
A képernyőre írást igénylő részfeladatok esetén – a mintához tartalmában hasonlóan – írja 
ki a képernyőre a feladat sorszámát (például: 3. feladat), és utaljon a kiírt tartalomra is! 
Ha a felhasználótól kér be adatot, jelenítse meg a képernyőn, hogy milyen értéket vár! Mindkét 
esetben az ékezetmentes kiírás is elfogadott.

---
##  1. feladat  
Olvassa be és tárolja el az `utca.json` állományban talált adatokat, és annak 
felhasználásával oldja meg a következő feladatokat! 
## 2. feladat
Hány telek adatai találhatók az állományban? Az eredményt írassa ki a mintának 
megfelelően a képernyőre! 
## 3. feladat
Kérje be egy tulajdonos adószámát, és írassa ki a mintához hasonlóan, hogy melyik utcában, 
milyen házszám alatt van építménye! Ha a megadott azonosító nem szerepel az 
adatállományban, akkor írassa ki a „Nem szerepel az adatállományban.” hibaüzenetet!
## 4. feladat
Készítsen függvényt ado néven, amely meghatározza egy adott építmény után fizetendő 
adót! A függvény paraméterlistájában szerepeljen az adósáv és az alapterület, visszaadott 
értéke pedig legyen a fizetendő adó! A következő feladatokban ezt a függvényt is 
felhasználhatja. 
## 5.feladat
Határozza meg, hogy hány építmény esik az egyes adósávokba, és mennyi az adó összege 
adósávonként! Az eredményt a mintának megfelelően írassa ki a képernyőre! 
## 6. feladat
Bár az utcák többé-kevésbé párhuzamosak a tó partjával, az egyes porták távolsága a parttól 
az utcában nem feltétlenül ugyanannyi. Emiatt néhány utcában – az ottani tulajdonosok 
felháborodására – egyes telkek eltérő sávba esnek. Listázza ki a képernyőre, hogy melyek 
azok az utcák, ahol a telkek sávokba sorolását emiatt felül kell vizsgálni! Feltételezheti, 
hogy minden utcában van legalább két telek. 
## 7. feladat
Határozza meg a fizetendő adót tulajdonosonként! A tulajdonos adószámát és a fizetendő 
összeget írassa ki a mintának megfelelően a fizetendo.json állományba! A fájlban 
minden tulajdonos adatai új sorban szerepeljenek, a tulajdonos adószámát egy szóközzel 
elválasztva kövesse az általa fizetendő adó teljes összege.

## Példa a szöveges kimenetek kialakításához: 
```
2. feladat. A mintában 543 telek szerepel. 
3. feladat. Egy tulajdonos adószáma: 68396 
Harmat utca 22 
Szepesi utca 17 
5. feladat 
A sávba 165 telek esik, az adó 20805600 Ft. 
B sávba 144 telek esik, az adó 13107000 Ft. 
C sávba 234 telek esik, az adó 3479600 Ft. 
6. feladat. A több sávba sorolt utcák: 
Besztercei 
Gyurgyalag 
Icce 
Kurta 
Rezeda 
Szepesi 
```
## Példa a fizetendo.json fájl kialakításához: 
(A fájl a megadott forrásállomány esetén 519 adatsort fog tartalmazni.)
```
38522 18000 
86379 0 
79906 12300 
… 
73850 204000 
74143 100000 
59801 563200 
73011 70400 
…
```
### Készítette:
Horváth Máté
Kovács Annabella
Major Bálint István
Németh Zalán