# Portfelik 

## Spis treści:
1. [Opis projektu](https://github.com/Vatorczek/gotki-test/new/main?filename=README.md#instrukcja-uruchomienia)
2. [Funkcjonalności](https://github.com/Vatorczek/gotki-test/new/main?filename=README.md#instrukcja-uruchomienia)
3. [Technologie](https://github.com/Vatorczek/gotki-test/new/main?filename=README.md#instrukcja-uruchomienia)
4. [Instrukcja uruchomienia](https://github.com/Vatorczek/gotki-test/new/main?filename=README.md#instrukcja-uruchomienia)

## Opis projektu

System monitorowania wydatków domowych

Portfelik to aplikacja internetowa wykonana w technologii ASP.NET Core MVC (.NET 10) umożliwiająca śledzenie i zarządzanie wydatkami domowymi. Użytkownik może dodawać wydatki, edytować je, usuwać oraz przeglądać listę zapisanych pozycji. Projekt został przygotowany zgodnie ze wzorcem MVC, czyli z podziałem na model, widok oraz kontroler.

## Funkcjonalności 

- Przeglądanie wydatków - lista wszystkich wydatków z widoczną sumą na dole tabeli
- Dodawanie nowych wydatków - formularz z polami: kategoria, kwota, data
- Edycja wydatku - możliwość zmiany danych istniejącego wpisu
- Usuwanie wydatku - usunięcie wpisu z potwierdzeniem
- Szczegóły wydatku - podgląd pojedynczego rekordu
- Wyszukiwanie po kategorii - filtrowanie listy wydatków w czasie rzeczywistym
- Walidacja formularza - sprawdzanie wymaganych pól, zakresu kwoty (0.01–999999.99 zł) oraz formatu daty

## Technologie

- ASP.NET Core MVC (.NET 10)
- Entity Framework Core
- Razor Views
- Bootstrap
- SQL Server LocalDB

## Instrukcja uruchomienia

**Wymagania:**
- .NET 10 SDK
- Visual Studio 2022 (lub nowszy) z pakietem ASP.NET and web development
- SQL Server LocalDB (instaluje się razem z Visual Studio)


**Kroki:**
1. Sklonuj repozytorium:
`git clone https://github.com/Vatorczek/MVCLab1.git`

2. Otwórz plik Portfelik.sln w Visual Studio.

3. Sprawdzić, czy zainstalowane są wymagane pakiety Entity Framework Core.

4. Uruchom migracje bazy danych — w Konsoli menedżera pakietów (Narzędzia → Menedżer pakietów NuGet → Konsola menedżera pakietów):  `Update-Database`

5. Uruchom aplikację klawiszem F5 (CTRL + F5) lub przyciskiem Start w Visual Studio.

6. Aplikacja otworzy się w przeglądarce. Przejdź do zakładki Wydatki w menu górnym aby zacząć korzystać z aplikacji.




