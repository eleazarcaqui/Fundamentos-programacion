using System;

class Program
{
    static void Main(string[] args)
    {
        // Variables

        string tipoVehiculo, clienteAntiguo;
        double costoReparacion, descVehiculo = 0, descAntiguo = 0;
        double descTotal, totalPagar;

        Console.WriteLine("=== MECÁNICA VENCEDOR ===");
        Console.WriteLine("Descuentos por tipo de vehículo:");
        Console.WriteLine("- Moto: S/. 10");
        Console.WriteLine("- Automóvil: S/. 20");
        Console.WriteLine("- Camión: S/. 30");
        Console.WriteLine();
        Console.WriteLine("Descuento adicional para clientes antiguos: S/. 15");
        Console.WriteLine();

        // Solicitar datos de entrada
        Console.Write("Ingrese el costo de reparación: S/. ");
        costoReparacion = double.Parse(Console.ReadLine());

        Console.Write("Ingrese el tipo de vehículo (Moto/Automovil/Camion): ");
        tipoVehiculo = Console.ReadLine().ToLower();

        Console.Write("¿Es cliente antiguo? (si/no): ");
        clienteAntiguo = Console.ReadLine().ToLower();

        if (tipoVehiculo == "moto")
        {
            descVehiculo = 10;
        }
        if (tipoVehiculo == "automovil" || tipoVehiculo == "automóvil")
        {
            descVehiculo = 20;
        }
        if (tipoVehiculo == "camion" || tipoVehiculo == "camión")
        {
            descVehiculo = 30;
        }
        if (clienteAntiguo == "si" || clienteAntiguo == "sí")
        {
            descAntiguo = 15;
        }
        descTotal = descVehiculo + descAntiguo;
        totalPagar = costoReparacion - descTotal;
        Console.WriteLine();
        Console.WriteLine("=== DETALLE DE LA REPARACIÓN ===");
        Console.WriteLine($"Tipo de vehículo: {char.ToUpper(tipoVehiculo[0]) + tipoVehiculo.Substring(1)}");
        Console.WriteLine($"Cliente antiguo: {(descAntiguo > 0 ? "Sí" : "No")}");
        Console.WriteLine($"Costo inicial: S/. {costoReparacion:F2}");
        Console.WriteLine();

        Console.WriteLine("=== DESCUENTOS APLICADOS ===");

        if (descVehiculo > 0)
        {
            Console.WriteLine($"Descuento por vehículo: S/. {descVehiculo:F2}");
        }
        else
        {
            Console.WriteLine("Descuento por vehículo: S/. 0.00 (tipo no válido)");
        }

        if (descAntiguo > 0)
        {
            Console.WriteLine($"Descuento cliente antiguo: S/. {descAntiguo:F2}");
        }
        else
        {
            Console.WriteLine("Descuento cliente antiguo: S/. 0.00");
        }

        Console.WriteLine($"DESCUENTO TOTAL: S/. {descTotal:F2}");
        Console.WriteLine();
        Console.WriteLine($"TOTAL A PAGAR: S/. {totalPagar:F2}");

        Console.WriteLine();
        Console.WriteLine("Presione cualquier tecla para salir...");
        Console.ReadKey();

        // string marca;
        // int años;
        // double costoInicial, porcImp = 0, descMarca = 0;
        // double costoDescontado, montoImp, costoFinal;

        // Console.WriteLine("=== VENTA DE AUTOS USADOS ===");
        // Console.WriteLine("Impuestos por años de antigüedad:");
        // Console.WriteLine("- 5 años: 3%");
        // Console.WriteLine("- 7 años: 5%");
        // Console.WriteLine("- 10 años: 7%");
        // Console.WriteLine();
        // Console.WriteLine("Descuentos por marca:");
        // Console.WriteLine("- Nissan: S/. 200");
        // Console.WriteLine("- Toyota: S/. 100");
        // Console.WriteLine("- Otras marcas: S/. 0");
        // Console.WriteLine();

        // // Solicitar datos de entrada
        // Console.Write("Ingrese el costo del vehículo: S/. ");
        // costoInicial = double.Parse(Console.ReadLine());

        // Console.Write("Ingrese la marca del vehículo: ");
        // marca = Console.ReadLine().ToLower();

        // Console.Write("Ingrese los años de antigüedad: ");
        // años = int.Parse(Console.ReadLine());

        // if (marca == "nissan")
        // {
        //     descMarca = 200;
        // }
        // if (marca == "toyota")
        // {
        //     descMarca = 100;
        // }

        // costoDescontado = costoInicial - descMarca;

        // if (años == 5)
        // {
        //     porcImp = 3;
        // }
        // if (años == 7)
        // {
        //     porcImp = 5;
        // }
        // if (años == 10)
        // {
        //     porcImp = 7;
        // }

        // montoImp = costoDescontado * (porcImp / 100);
        // costoFinal = costoDescontado + montoImp;

        // // Mostrar salida
        // Console.WriteLine();
        // Console.WriteLine("=== DETALLE DEL VEHÍCULO ===");
        // Console.WriteLine($"Marca: {char.ToUpper(marca[0]) + marca.Substring(1)}");
        // Console.WriteLine($"Años de antigüedad: {años} años");
        // Console.WriteLine($"Costo inicial: S/. {costoInicial:F2}");
        // Console.WriteLine();

        // Console.WriteLine("=== CÁLCULOS ===");

        // if (descMarca > 0)
        // {
        //     Console.WriteLine($"Descuento por marca: S/. {descMarca:F2}");
        //     Console.WriteLine($"Costo después del descuento: S/. {costoDescontado:F2}");
        // }
        // else
        // {
        //     Console.WriteLine("Descuento por marca: S/. 0.00 (otras marcas)");
        //     Console.WriteLine($"Costo después del descuento: S/. {costoDescontado:F2}");
        // }

        // if (porcImp > 0)
        // {
        //     Console.WriteLine($"Impuesto aplicado ({porcImp}%): S/. {montoImp:F2}");
        // }
        // else
        // {
        //     Console.WriteLine("Impuesto aplicado: S/. 0.00 (años no contemplados en tabla)");
        // }

        // Console.WriteLine();
        // Console.WriteLine($"COSTO FINAL: S/. {costoFinal:F2}");

        // Console.WriteLine();
        // Console.WriteLine("Presione cualquier tecla para salir...");
        // Console.ReadKey();

        // string rubro;
        // double montoCompra, porcDesc = 0, porcImp = 0;
        // double montoDesc, montoDescontado, montoImp, pagoTotal;

        // Console.WriteLine("=== SUPERMERCADO - SISTEMA DE DESCUENTOS E IMPUESTOS ===");
        // Console.WriteLine("Descuentos por monto de compra:");
        // Console.WriteLine("- S/. 100 - 250: 3% descuento");
        // Console.WriteLine("- S/. 251 - 500: 5% descuento");
        // Console.WriteLine("- S/. 501 a más: 10% descuento");
        // Console.WriteLine();
        // Console.WriteLine("Impuestos por rubro:");
        // Console.WriteLine("- Comestibles: 15%");
        // Console.WriteLine("- Artefactos: 30%");
        // Console.WriteLine();
        // Console.Write("Ingrese el monto de compra: S/. ");
        // montoCompra = double.Parse(Console.ReadLine());

        // Console.Write("Ingrese el rubro (Comestibles/Artefactos): ");
        // rubro = Console.ReadLine().ToLower();

        // if (montoCompra >= 100 && montoCompra <= 250)
        // {
        //     porcDesc = 3;
        // }
        // if (montoCompra >= 251 && montoCompra <= 500)
        // {
        //     porcDesc = 5;
        // }
        // if (montoCompra >= 501)
        // {
        //     porcDesc = 10;
        // }
        // montoDesc = montoCompra * (porcDesc / 100);
        // montoDescontado = montoCompra - montoDesc;

        // if (rubro == "comestibles")
        // {
        //     porcImp = 15;
        // }
        // if (rubro == "artefactos")
        // {
        //     porcImp = 30;
        // }

        // montoImp = montoDescontado * (porcImp / 100);

        // pagoTotal = montoDescontado + montoImp;

        // Console.WriteLine();
        // Console.WriteLine("=== DETALLE DE LA COMPRA ===");
        // Console.WriteLine($"Monto inicial: S/. {montoCompra:F2}");
        // Console.WriteLine($"Rubro: {char.ToUpper(rubro[0]) + rubro.Substring(1)}");
        // Console.WriteLine();

        // Console.WriteLine("=== CÁLCULOS ===");

        // if (porcDesc > 0)
        // {
        //     Console.WriteLine($"Descuento aplicado ({porcDesc}%): S/. {montoDesc:F2}");
        //     Console.WriteLine($"Monto después del descuento: S/. {montoDescontado:F2}");
        // }
        // else
        // {
        //     Console.WriteLine("Descuento aplicado: S/. 0.00 (monto menor a S/. 100)");
        //     Console.WriteLine($"Monto después del descuento: S/. {montoCompra:F2}");
        // }

        // if (porcImp > 0)
        // {
        //     Console.WriteLine($"Impuesto aplicado ({porcImp}%): S/. {montoImp:F2}");
        // }
        // else
        // {
        //     Console.WriteLine("Impuesto aplicado: S/. 0.00 (rubro no válido)");
        // }

        // Console.WriteLine();
        // Console.WriteLine($"PAGO TOTAL: S/. {pagoTotal:F2}");

        // Console.WriteLine();
        // Console.WriteLine("Presione cualquier tecla para salir...");
        // Console.ReadKey();

        // string sabor;
        // int cantidad;
        // double precioUni, subtotal, porcDesc = 0;
        // double descSabor, descAdicional = 0, descTotal, totalPagar;

        // Console.WriteLine("=== BIENVENIDO A HELADERÍA D'ONOFRIO ===");
        // Console.WriteLine("Sabores disponibles:");
        // Console.WriteLine("- Fresa (descuento 1%)");
        // Console.WriteLine("- Lúcuma (descuento 3%)");
        // Console.WriteLine("- Chocolate (descuento 5%)");

        // // Solicitar datos de entrada
        // Console.Write("Ingrese el sabor del helado (Fresa/Lucuma/Chocolate): ");
        // sabor = Console.ReadLine().ToLower();

        // Console.Write("Ingrese el precio unitario del helado: S/. ");
        // precioUni = double.Parse(Console.ReadLine());

        // Console.Write("Ingrese la cantidad de helados: ");
        // cantidad = int.Parse(Console.ReadLine());

        // subtotal = precioUni * cantidad;

        // if (sabor == "fresa")
        // {
        //     porcDesc = 1;
        // }
        // if (sabor == "lucuma" || sabor == "lúcuma")
        // {
        //     porcDesc = 3;
        // }
        // if (sabor == "chocolate")
        // {
        //     porcDesc = 5;
        // }

        // descSabor = subtotal * (porcDesc / 100);

        // if (cantidad > 10)
        // {
        //     descAdicional = 5;
        // }

        // descTotal = descSabor + descAdicional;

        // totalPagar = subtotal - descTotal;

        // Console.WriteLine("=== DETALLE DE LA COMPRA ===");
        // Console.WriteLine($"Sabor: {char.ToUpper(sabor[0]) + sabor.Substring(1)}");
        // Console.WriteLine($"Cantidad: {cantidad} helados");
        // Console.WriteLine($"Precio unitario: S/. {precioUni:F2}");
        // Console.WriteLine($"Subtotal: S/. {subtotal:F2}");
        // Console.WriteLine();

        // Console.WriteLine("=== DESCUENTOS APLICADOS ===");
        // Console.WriteLine($"Descuento por sabor ({porcDesc}%): S/. {descSabor:F2}");

        // if (cantidad > 10)
        // {
        //     Console.WriteLine($"Descuento adicional (más de 10 unidades): S/. {descAdicional:F2}");
        // }
        // else
        // {
        //     Console.WriteLine("Descuento adicional: S/. 0.00 (se requieren más de 10 unidades)");
        // }

        // Console.WriteLine($"DESCUENTO TOTAL: S/. {descTotal:F2}");
        // Console.WriteLine();
        // Console.WriteLine($"TOTAL A PAGAR: S/. {totalPagar:F2}");

        // Console.WriteLine();
        // Console.WriteLine("Presione cualquier tecla para salir...");
        // Console.ReadKey();

    }
}
