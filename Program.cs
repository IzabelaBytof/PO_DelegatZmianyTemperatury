SensorTemperatury sensorTemperatury = new SensorTemperatury(23);
 
// Tworzenie obiektu obsługującego zdarzenie zmiany temperatury
ObslugaZmianyTemperatury obslugaZmianyTemperatury1 = new ObslugaZmianyTemperatury("Obsługa 1");
ObslugaZmianyTemperatury obslugaZmianyTemperatury2 = new ObslugaZmianyTemperatury("Obsługa 2");
 
// Dodawanie metody obsługującej zdarzenie do delegata zdarzenia
sensorTemperatury.ZmianaTemperatury += obslugaZmianyTemperatury1.ObsluzZmianeTemperatury;
sensorTemperatury.ZmianaTemperatury += obslugaZmianyTemperatury2.ObsluzZmianeTemperatury;
 
// Symulowanie zmiany temperatury
sensorTemperatury.AktualnaTemperatura = 25;
sensorTemperatury.AktualnaTemperatura = 30;
sensorTemperatury.AktualnaTemperatura = 22;