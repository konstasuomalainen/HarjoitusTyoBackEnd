# Harjoitustyö Back-End

## Johdanto

Kurssin harjoitustyössä kehitettiin backend viestintäsovellus, jonka pääasiallinen tarkoitus on mahdollistaa käyttäjien välinen viestintä. Sovelluksella voi lähettää julkisia ja sekä yksityisviestejä.

## Tietomallit

Sovelluksen keskeiset tietomallit ovat seuraavat:

Käyttäjä:
- Tunnus
- Salasana
- Etunimi
- Sukunimi
- Liittymisaika
- Viimeinen loginaika
- Käyttäjä ID

Viesti:
- Otsikko
- Viesti
- Lähettäjä (viittaus käyttäjän ID:hen)
- Vastaanottaja (viittaus käyttäjän ID:hen)
- Linkki edelliseen viestiin (jos vastaus viestiketjuun)
- Viesti ID

## Toiminnallisuudet

Sovellus tarjoaa seuraavat päätoiminnallisuudet:

- Viestien Lähettäminen:
  - Käyttäjät voivat luoda ja lähettää sekä julkisia että yksityisviestejä.

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
