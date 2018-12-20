﻿using DataAccessLayer.Controladores;
using DataAccessLayer.Convertidores;
using DataAccessLayer.Intefaces;
using SHARE.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    partial class Vehiculos
    {
        IDALE_Sensor DALS = new DALE_Sensores();
        IDALE_Tipo_Evento DALT = new DALE_Tipo_Evento();
        IDALE_Empresa DALEmp = new DALE_Empresa();

        public void setModel(Vehiculo veh)
        {
            Id = veh.Id;
            Id_Empleado = veh.Id_Empleado;
            Marca = veh.Marca;
            Modelo = veh.Modelo;
            RUT_Empresa = veh.EmpresaRef;
            Activo = veh.Activo;
            this.Sensores = new ConvertType().SensorToSensorDB(veh.Lista_Sensores);
            this.Tipo_Evento = new ConvertType().Tipo_EventoToTipo_EventoDB(veh.Lista_Tipo_Eventos);
            this.Eventos = new ConvertType().EventoToEventoDB(veh.Lista_Eventos);
        }


        
        public Vehiculo getEntity()
        {
            Vehiculo nuevo = new Vehiculo();
            nuevo.Id = Id;
            nuevo.Id_Empleado = (int)Id_Empleado;
            nuevo.Marca = Marca;
            nuevo.Modelo = Modelo;
            nuevo.Activo = (bool)Activo;
            nuevo.EmpresaRef = (int)RUT_Empresa;
            nuevo.Lista_Sensores = new ConvertType().SensorDBToSensor(this.Sensores.ToList<Sensores>());
            nuevo.Lista_Tipo_Eventos = new ConvertType().Tipo_EventoDBToTipo_Evento(this.Tipo_Evento.ToList<Tipo_Eventos>());
            nuevo.Lista_Eventos = new ConvertType().EventoDBToEvento(this.Eventos.ToList<Eventos>());
            return nuevo;
        }

        
    }
}
