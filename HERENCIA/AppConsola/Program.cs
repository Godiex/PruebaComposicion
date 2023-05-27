using AppConsola;



List<Mascota> mascotas = new List<Mascota>{
    new Mascota("yerri", "Perro", "Buldog Frances", DateTime.Now, true, false, "esta sano")
};

Cliente cliente = new Cliente("Yeni", "Villa Rosario", mascotas);
cliente.AgregarCorreo("yeni@devzeros.com");
cliente.AgregarTelefonos("32145678");



Veterinaria vet = new Veterinaria("Veterinaria DevZeros");
vet.MostrarClientes();