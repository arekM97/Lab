# Zastosowanie aplikacji

Aplikacja służy do ewidencji urządzeń po oględzinach dokonanych przez służby eksploatacyjne firmy. Przechowuje dane o aktualnym stanie technicznym urządzeń oraz zawiera informacje o dostrzeżonych usterkach w trakcie oględzin. Dodatkowo graficznie przedstawia udział uszkodzonych urządzeń w stosounku do sprawnych - co uławia ocenę aktualnego stanu technicznego urządzeń w przedsiębiorstwie.
Dostęp do danych mają tylko użytkownicy posiadający konto w bazie danych.

# Przed uruchomieniem aplikacji

**1) Tworzenie bazę danych SQL**

*Visual Studio: Widok > Eksplorator rozwiązań > PPM na labki > Otwórz w terminalu*
```
$ SQLLocalDb create labki
$ SQLLocalDb start labki
$ SQLCmd -S "(localdb)\labki"
$ SQLCmd -S "(localdb)\labki"
$ CREATE DATABASE [labki_database];
$ GO

```
**2) Łączenie się z bazą danych**

*Visual Studio: Widok > Ekslorator servera > Łączenie z bazą danych*

Okno Dodaj Połączenie:<br/>
Nazwa servera: (localdb)\labki<br/>
Wybierz lub wprowadź nazwę bazy danych: labki_database >OK

**3) Dodanie migracji**

*Visual Studio: Widok > Eksplorator rozwiązań > PPM na labki > Otwórz w terminalu*


```
$ dotnet tool install --global dotnet-ef --version 5.0.11
$ dotnet ef migrations add Start
$ dotnet ef database update

```

# Działanie aplikacji - strona główna

![1](https://user-images.githubusercontent.com/91375599/155885642-20b37914-107e-472d-a147-4a02f8077942.PNG)

# Działanie aplikacji - dodawanie oględzin

![4](https://user-images.githubusercontent.com/91375599/155886838-c9d43e82-dbb0-4fca-999e-59bcebf8e3df.PNG)

# Działanie aplikacji - lista urządzeń

![2](https://user-images.githubusercontent.com/91375599/155885648-e9002646-59a3-45fe-90b7-ac5eb79c2666.PNG)

# Działanie aplikacji - wykres

![3](https://user-images.githubusercontent.com/91375599/155885653-a7bac138-a9cd-4e96-8240-53333df0a581.png)
