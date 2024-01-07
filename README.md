# Harjoitustyö Back-End

## Johdanto

Kurssin harjoitustyössä kehitettiin C#-kielellä backend-sovellus, jonka pääasiallinen tarkoitus on mahdollistaa käyttäjien välinen viestintä.

## Käytössä olevat Tietomallit

Käyttäjä:
- Tunnus
- Salasana
- Etunimi
- Sukunimi
- Liittymisaika
- Viimeinen loginaika


Viesti:
- Otsikko
- Viesti
- Lähettäjä 
- Vastaanottaja
- Linkki edelliseen viestiin (jos vastaus viestiketjuun)

Kaikilla malleilla on oma ID, jolla ne tunnistetaan ja yhdistetään toisiinsa.

## Toiminnallisuudet

Sovellus tarjoaa seuraavat päätoiminnallisuudet:

- Viestit
  - Käyttäjät voivat luoda ja lähettää sekä julkisia, että yksityisviestejä.

- Viestiketjut:
  - Viestit voivat muodostaa viestiketjuja vastaamalla olemassaoleviin viesteihin.

- Yksityisyys:
  - Yksityiset viestit ovat näkyvissä ainoastaan vastaanottajalle ja lähettäjälle.

- Viestien Muokkaus ja Poisto:
  - Käyttäjät voivat muokata ja poistaa omia viestejään.

- Profiilin Hallinta:
  - Käyttäjä voi muokata omaa profiiliaan ja poistaa sen tarvittaessa.

## Sovelluksen Rakenne ja Rajapinnat

Sovellus noudattaa seuraavaa rakennetta:

- Käyttöliittymärajapinta (UI):
  - Sovellusta voi käyttää esimerkiksi web-käyttöliittymän kautta.

- RESTful API:
  - Sovellusta voi käyttää esim. Postmanin kautta, jonka avulla käyttäjät voivat suorittaa eri toimintoja.
 
## Lisäominaisuudet
  - Sovelluksessa ei ole toiminnallisuutta viestien ilmoituksille.
  - Viesteihin ei voi lisätä tiedostoja.
  - Sovellus on yksikielinen.
  - Ei ole tilastoja sovelluksen käytöstä.
