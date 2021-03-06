﻿using System;

namespace Telerik.UI.Xaml.Controls.Grid
{
    /// <summary>
    /// Defines the available selection modes within a <see cref="RadDataGrid"/> component.
    /// </summary>
    public enum DataGridSelectionMode
    {
        /// <summary>
        /// No selection is allowed.
        /// </summary>
        None,

        /// <summary>
        /// Single unit only may be selected. The selection unit is described by the <see cref="RadDataGrid.SelectionUnit"/> property.
        /// </summary>
        Single,

        /// <summary>
        /// Multiple units may be selected. The selection unit is described by the <see cref="RadDataGrid.SelectionUnit"/> property.
        /// </summary>
        Multiple,
    }   
}
