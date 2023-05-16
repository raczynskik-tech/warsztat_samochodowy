## Warsztat v2.0
Projekt grupowy jako zaliczenie przedmiotów:
* Projekt bazodanowy
* Programowanie III

## Założenia projektu
* Stworzenie aplikacji do obsługi warsztatu samochodowego.
* Podział aplikacji między część serwerową zarządzaną przez administratora - np. właściciela warsztatu oraz część kliencką - pracownik warsztatu.
* Pracownik warsztatu podczas pracy otrzymuje pojazdy do naprawy, części wziązane z konkretną naprawą wybiera z listy.
* Po zakończeniu pracy pracownika, klient warsztatu zostaje powiadomiony SMS oraz generowana jest faktura.

## Wykorzystane technologie oraz mój udział
* Warstwa graficzna - Windows Presentation Foundation (tworzyłem część administatora - 'widgety' na ekranie głównym, oraz część kliencką)
* Łączenie z bazą danych - Entity Framework 6 (tworzyłem komunikację z bazą danych oraz ORM)
* Baza danych PostgreSQL
* Generowanie faktury (brak mojego udziału)
* Wysyłanie SMS przez bramkę SMS (brak mojego udziału)
