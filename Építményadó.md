
# 4. �p�tm�nyad�
Egy Balaton-parti �nkorm�nyzat �p�tm�nyad�t vezet be. Az ad� m�rt�ke a telken l�v� 
�p�tm�ny alapter�let�t�l �s a teleknek a Balatont�l m�rt t�vols�g�t�l f�gg. 
A telkeket a Balatonpartt�l m�rt t�vols�gt�l f�gg�en h�rom s�vba sorolt�k be. Az A s�vba 
azok a telkek ker�ltek, amelyek 300 m�tern�l k�zelebb vannak a t�hoz a B s�v az el�z�n t�l 
600 m�ter t�vols�gig terjed, a t�bbi telek a C s�vba tartozik. Az �p�tm�ny ut�n 
n�gyzetm�terenk�nt fizetend� �sszeg s�vonk�nt elt�r�, azonban, ha az �gy kisz�m�tott �sszeg 
nem �ri el a 10.000 Ft-ot, akkor az adott �p�tm�ny ut�n nem kell ad�t fizetni. 

--- 
A test�leti d�nt�st az Ad� �gyoszt�ly egy mint�val k�sz�tette el�, amely csup�n n�h�ny utca 
adatait tartalmazza. Ezek az adatok az `utca.txt` f�jlban vannak. A f�jl els� sor�ban a h�rom 
ad�s�vhoz tartoz� n�gyzetm�terenk�nt fizetend� �sszeg tal�lhat� A, B, C sorrendben, egy-egy 
sz�k�zzel elv�lasztva: 
```
800 600 100   
�  
33366 Aradi 8A C 180  
22510 Aradi 8B C 137  
90561 Aradi 10 C 168  
� 
```
---
A t�bbi sorban egy-egy �p�tm�ny adatai szerepelnek egy-egy sz�k�zzel elv�lasztva. Az els� 
a telek tulajdonos�nak �tjegy� ad�sz�ma; egy tulajdonosnak t�bb telke is lehet. A m�sodik adat 
az utca neve, amely nem tartalmazhat sz�k�zt. A harmadik adat a h�zsz�m, majd az ad�s�v 
megnevez�se, v�g�l az �p�tm�ny alapter�lete k�vetkezik. A minta harmadik sor�ban p�ld�ul 
azt l�tjuk, hogy a 33366 ad�sz�m� tulajdonos telke az Aradi utca 8A-ban tal�lhat�, �s a C s�vba 
es� telken �ll� �p�tm�ny alapter�lete 180 m^2^.

---
A f�jl legfeljebb 1000 telek adatait tartalmazza. A feladat megold�sa sor�n kihaszn�lhatja, 
hogy a f�jlban az adatok utca, azon bel�l pedig h�zsz�m szerinti sorrendben k�vetkeznek.
K�sz�tsen programot, amely az `utca.txt` �llom�ny adatait felhaszn�lva az al�bbi 
k�rd�sekre v�laszol! A program forr�sk�dj�t mentse epitmenyado n�ven! (A program 
meg�r�sakor a felhaszn�l� �ltal megadott adatok helyess�g�t, �rv�nyess�g�t nem kell 
ellen�riznie, �s felt�telezheti, hogy a rendelkez�sre �ll� adatok a le�rtaknak megfelelnek.) 
A k�perny�re �r�st ig�nyl� r�szfeladatok eset�n � a mint�hoz tartalm�ban hasonl�an � �rja 
ki a k�perny�re a feladat sorsz�m�t (p�ld�ul: 3. feladat), �s utaljon a ki�rt tartalomra is! 
Ha a felhaszn�l�t�l k�r be adatot, jelen�tse meg a k�perny�n, hogy milyen �rt�ket v�r! Mindk�t 
esetben az �kezetmentes ki�r�s is elfogadott.

---
##  1. feladat  
Olvassa be �s t�rolja el az `utca.txt` �llom�nyban tal�lt adatokat, �s annak 
felhaszn�l�s�val oldja meg a k�vetkez� feladatokat! 
## 2. feladat
H�ny telek adatai tal�lhat�k az �llom�nyban? Az eredm�nyt �rassa ki a mint�nak 
megfelel�en a k�perny�re! 
## 3. feladat
K�rje be egy tulajdonos ad�sz�m�t, �s �rassa ki a mint�hoz hasonl�an, hogy melyik utc�ban, 
milyen h�zsz�m alatt van �p�tm�nye! Ha a megadott azonos�t� nem szerepel az 
adat�llom�nyban, akkor �rassa ki a �Nem szerepel az adat�llom�nyban.� hiba�zenetet!
## 4. feladat
K�sz�tsen f�ggv�nyt ado n�ven, amely meghat�rozza egy adott �p�tm�ny ut�n fizetend� 
ad�t! A f�ggv�ny param�terlist�j�ban szerepeljen az ad�s�v �s az alapter�let, visszaadott 
�rt�ke pedig legyen a fizetend� ad�! A k�vetkez� feladatokban ezt a f�ggv�nyt is 
felhaszn�lhatja. 
## 5.feladat
Hat�rozza meg, hogy h�ny �p�tm�ny esik az egyes ad�s�vokba, �s mennyi az ad� �sszege 
ad�s�vonk�nt! Az eredm�nyt a mint�nak megfelel�en �rassa ki a k�perny�re! 
## 6. feladat
B�r az utc�k t�bb�-kev�sb� p�rhuzamosak a t� partj�val, az egyes port�k t�vols�ga a partt�l 
az utc�ban nem felt�tlen�l ugyanannyi. Emiatt n�h�ny utc�ban � az ottani tulajdonosok 
felh�borod�s�ra � egyes telkek elt�r� s�vba esnek. List�zza ki a k�perny�re, hogy melyek 
azok az utc�k, ahol a telkek s�vokba sorol�s�t emiatt fel�l kell vizsg�lni! Felt�telezheti, 
hogy minden utc�ban van legal�bb k�t telek. 
## 7. feladat
Hat�rozza meg a fizetend� ad�t tulajdonosonk�nt! A tulajdonos ad�sz�m�t �s a fizetend� 
�sszeget �rassa ki a mint�nak megfelel�en a fizetendo.txt �llom�nyba! A f�jlban 
minden tulajdonos adatai �j sorban szerepeljenek, a tulajdonos ad�sz�m�t egy sz�k�zzel 
elv�lasztva k�vesse az �ltala fizetend� ad� teljes �sszege.

## P�lda a sz�veges kimenetek kialak�t�s�hoz: 
```
2. feladat. A mint�ban 543 telek szerepel. 
3. feladat. Egy tulajdonos ad�sz�ma: 68396 
Harmat utca 22 
Szepesi utca 17 
5. feladat 
A s�vba 165 telek esik, az ad� 20805600 Ft. 
B s�vba 144 telek esik, az ad� 13107000 Ft. 
C s�vba 234 telek esik, az ad� 3479600 Ft. 
6. feladat. A t�bb s�vba sorolt utc�k: 
Besztercei 
Gyurgyalag 
Icce 
Kurta 
Rezeda 
Szepesi 
```
## P�lda a fizetendo.txt f�jl kialak�t�s�hoz: 
(A f�jl a megadott forr�s�llom�ny eset�n 519 adatsort fog tartalmazni.)
```
38522 18000 
86379 0 
79906 12300 
� 
73850 204000 
74143 100000 
59801 563200 
73011 70400 
�
```