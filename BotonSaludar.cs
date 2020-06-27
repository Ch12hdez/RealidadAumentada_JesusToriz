﻿/*
Nombre de desarrollador: Jesús Alberto Toríz Hernández
Asignatura: Realidad Aumentada
Profesor: Josué Rivas Díaz
Nombre de código: Boton Saludar
Descripción: Codigo encarcado de al aparecer en pantalla se reproduzca la animacion indicada
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonSaludar : MonoBehaviour
{
    public Animator theMan;

    //Codigo que al activarse automaticamente manda un mensaje en busca de la animación que se desea que salga en pantalla, sirve para que identifique automaticamente la animacion, que se la aplique al personaje correcto y cuando entre en contacto el identificador se active

    public void PlayAnimation()
    {
        theMan.Play("wave");
    }
}
