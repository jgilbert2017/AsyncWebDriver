// Copyright (c) Oleg Zudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Drawing;
using System.Threading.Tasks;
using Zu.WebBrowser.BasicTypes;

namespace Zu.AsyncWebDriver.Interactions.Internal
{
    /// <summary>
    ///     Provides location of the element using various frames of reference.
    /// </summary>
    public interface ICoordinates
    {
        /// <summary>
        ///     Gets the location of an element in absolute screen coordinates.
        /// </summary>
        Task<WebPoint> LocationOnScreen { get; }

        /// <summary>
        ///     Gets the location of an element relative to the origin of the view port.
        /// </summary>
        Task<WebPoint> LocationInViewport { get; }

        /// <summary>
        ///     Gets the location of an element's position within the HTML DOM.
        /// </summary>
        Task<WebPoint> LocationInDom { get; }

        /// <summary>
        ///     Gets a locator providing a user-defined location for this element.
        /// </summary>
        Task<object> AuxiliaryLocator { get; }
    }
}