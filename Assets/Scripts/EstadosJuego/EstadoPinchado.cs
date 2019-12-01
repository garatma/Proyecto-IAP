using System;
using UnityEngine;

public class EstadoPinchado : Estado
{
    public ControladorJuego juego;

    public EstadoPinchado(ControladorJuego ctrlJuego)
    {
        // Constructor
        this.juego = ctrlJuego;
    }

    public override void Ejecutar()
    {
        // Realiza la acci�n correspondiente

		juego.disco.desactivar();

		if (juego.reiniciaronPunto())
		{
			juego.reinicioPuntoListo();
            juego.disco.activar();
			juego.resetearDisco(-3.2f);
			juego.managerMenus.cambiarAPartida();
			juego.cambiarEstado(new EstadoSacaJugador1(juego));
		}
    }
}
