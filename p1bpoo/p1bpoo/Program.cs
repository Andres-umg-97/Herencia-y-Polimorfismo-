
using p1bpoo.MisClases;

Vehiculo miCarro = new Vehiculo(2026,"Azul","Ferrari");

Vehiculo miCarro2 = new Vehiculo(2000, "Rojo", "Ford");

CarroElectrico miElectrico = new CarroElectrico(2026, "Amarillo", "Nissan");

AutoDeCombustion miAuto = new AutoDeCombustion(2025, "Negro", "Toyota");

Motocicleta miMoto = new Motocicleta(2024, "Morado", "Suzuki");

miCarro.InformacionVehiculo();
miCarro2.InformacionVehiculo();
miElectrico.InformacionVehiculo();
miElectrico.cargarBateria();
miAuto.InformacionVehiculo();
miAuto.CargarGasolina();
miMoto.InformacionVehiculo();
Console.WriteLine("El nivel de bateria es: {0}",miElectrico.NivelBateria());
Console.WriteLine("El nivel del tanque es: {0}",miAuto.NivelGasolina());




