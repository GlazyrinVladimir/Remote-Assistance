
namespace GoogleARCore.Examples.ComputerVision
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;
    using UnityEngine.EventSystems;

    /// <summary>
    /// A Monobehavior that handles pointer click event with customizable action.
    /// </summary>
    public class PointClickHandler : MonoBehaviour, IPointerClickHandler
    {
        /// <summary>
        /// Action which get called when the PointClickHandler detects a point click.
        /// </summary>
        public event Action OnPointClickDetected;

        /// <summary>
        /// Detect if a click occurs.
        /// </summary>
        /// <param name="pointerEventData">The PointerEventData of the click.</param>
        public void OnPointerClick(PointerEventData pointerEventData)
        {
            if (OnPointClickDetected != null)
            {
                OnPointClickDetected();
            }
        }
    }
}
