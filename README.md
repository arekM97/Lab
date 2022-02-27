# Lab

# Przed uruchomieniem aplikacji

## 1) Należy utworzyć bazę danych SQL


```
$ SQLLocalDb create labki
$ SQLLocalDb start labki
$ SQLCmd -S "(localdb)\labki"
$ SQLCmd -S "(localdb)\labki"
$ CREATE DATABASE [labki_database];
$ GO

```
## 2) Należy połączyć się z bazą danych

* Visual Studio: Widok > Ekslorator servera > Łączenie z bazą danych

* Okno Dodaj Połączenie - Nazwa servera: (localdb)\labki
* Okno Dodaj Połączenie - Wybierz lub wprowadź nazwę bazy danych: labki_database
* Okno Dodaj Połączenie ->OK

## 2) Należy dodać migrację

Visual Studio: Eksplorator rozwiązań



