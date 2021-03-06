﻿using System.Collections.Generic;
using System.Drawing;
using NUnit.Framework;
using Subgurim.Maps.Core.Google;
using Subgurim.Maps.Core.Google.Enums;
using Subgurim.Maps.Core.Google.Options;

namespace Subgurim.Maps.Core.Tests.Core
{
    [TestFixture]
    public class MapOptionsTests
    {
        private MapOptions options;

        [SetUp]
        public void SetUpTest()
        {
            options = new MapOptions();
        }

        [Test]
        public void Empty_Options_Render_Empty_String()
        {
            Assert.That(options.ToString(), Is.EqualTo(",{mapTypeControl:false,mapTypeId:google.maps.MapTypeId.ROADMAP}"));
        }

        [Test]
        public void BackGroundColor_Renders_Option()
        {
            options.BackgroundColor = Color.Red;

            Assert.That(options.ToString(),
                        Is.EqualTo(",{backgroundColor:'#FF0000',mapTypeControl:false,mapTypeId:google.maps.MapTypeId.ROADMAP}"));
        }

        [Test]
        public void Center_Renders_Option()
        {
             options.Center = new LatLng(45.0, 23.0);

            Assert.That(options.ToString(),
                        Is.EqualTo(
                            ",{center:new google.maps.LatLng(45,23),mapTypeControl:false,mapTypeId:google.maps.MapTypeId.ROADMAP}"));
        }

        [Test]
        public void DisableDefaultUI_Renders_Option()
        {
            options.DisableDefaultUI = true;

            Assert.That(options.ToString(),
                        Is.EqualTo(
                            ",{disableDefaultUI:true,keyboardShortcuts:true,mapTypeControl:false,mapTypeId:google.maps.MapTypeId.ROADMAP}"));
        }

        [Test]
        public void DisableDoubleClickZoom_Renders_Option()
        {
            options.DisableDoubleClickZoom = true;

            Assert.That(options.ToString(),
                        Is.EqualTo(",{disableDoubleClickZoom:true,mapTypeControl:false,mapTypeId:google.maps.MapTypeId.ROADMAP}"));
        }

        [Test]
        public void Draggable_Renders_Option()
        {
            options.Draggable = false;

            Assert.That(options.ToString(),
                        Is.EqualTo(",{draggable:false,mapTypeControl:false,mapTypeId:google.maps.MapTypeId.ROADMAP}"));
        }

        [Test]
        public void DraggableCursor_Renders_Option()
        {
            options.DraggableCursor = Cursor.Crosshair;

            Assert.That(options.ToString(),
                        Is.EqualTo(",{draggableCursor:'crosshair',mapTypeControl:false,mapTypeId:google.maps.MapTypeId.ROADMAP}"));
        }

        [Test]
        public void DraggingCursor_Renders_Option()
        {
            options.DraggingCursor = Cursor.Crosshair;

            Assert.That(options.ToString(),
                        Is.EqualTo(",{draggingCursor:'crosshair',mapTypeControl:false,mapTypeId:google.maps.MapTypeId.ROADMAP}"));
        }

        [Test]
        public void Heading_Renders_Option()
        {
            options.Heading = 45;

            Assert.That(options.ToString(), Is.EqualTo(",{heading:45,mapTypeControl:false,mapTypeId:google.maps.MapTypeId.ROADMAP}"));
        }

        [Test]
        public void KeyboardShortcuts_Renders_Option()
        {
            options.KeyboardShortcuts = false;

            Assert.That(options.ToString(),
                        Is.EqualTo(",{keyboardShortcuts:false,mapTypeControl:false,mapTypeId:google.maps.MapTypeId.ROADMAP}"));
        }

        [Test]
        public void MapTypeControl_Renders_Option()
        {
            options.MapTypeControl = true;

            Assert.That(options.ToString(),
                        Is.EqualTo(",{mapTypeControl:true,mapTypeId:google.maps.MapTypeId.ROADMAP}"));
        }

        [Test]
        public void MapTypeControlOptions_Renders_Option()
        {
            options.MapTypeControlOptions = new MapTypeControlOptions(typeof(Map)) { Position = ControlPosition.Bottom_Left };

            Assert.That(options.ToString(),
                        Is.EqualTo(
                            ",{mapTypeControl:false,mapTypeControlOptions:{position:google.maps.ControlPosition.BOTTOM_LEFT},mapTypeId:google.maps.MapTypeId.ROADMAP}"));
        }

        [Test]
        public void MapTypeId_Renders_Option()
        {
            options.MapTypeId = MapTypeIds.Satellite;

            Assert.That(options.ToString(), Is.EqualTo(",{mapTypeControl:false,mapTypeId:google.maps.MapTypeId.SATELLITE}"));
        }

        [Test]
        public void MaxZoom_MinZoom_Renders_Option()
        {
            options.MaxZoom = 7;
            options.MinZoom = 3;

            Assert.That(options.ToString(),
                        Is.EqualTo(",{mapTypeControl:false,mapTypeId:google.maps.MapTypeId.ROADMAP,maxZoom:7,minZoom:3}"));
        }

        [Test]
        public void NoClear_MinZoom_Renders_Option()
        {
            options.NoClear = true;

            Assert.That(options.ToString(), Is.EqualTo(",{mapTypeControl:false,mapTypeId:google.maps.MapTypeId.ROADMAP,noClear:true}"));
        }

        [Test]
        public void OverviewMapControl_Renders_Option()
        {
            options.OverviewMapControl = true;

            Assert.That(options.ToString(),
                        Is.EqualTo(",{mapTypeControl:false,mapTypeId:google.maps.MapTypeId.ROADMAP,overviewMapControl:true}"));
        }

        [Test]
        public void OverviewMapControlOptions_Renders_Option()
        {
            options.OverviewMapControlOptions = new OverviewMapControlOptions() {Opened = true};

            Assert.That(options.ToString(),
                        Is.EqualTo(
                            ",{mapTypeControl:false,mapTypeId:google.maps.MapTypeId.ROADMAP,overviewMapControlOptions:{opened:true}}"));
        }

        [Test]
        public void PanControl_Renders_Option()
        {
            options.PanControl = true;

            Assert.That(options.ToString(),
                        Is.EqualTo(",{mapTypeControl:false,mapTypeId:google.maps.MapTypeId.ROADMAP,panControl:true}"));
        }

        [Test]
        public void PanControlOptions_Renders_Option()
        {
            options.PanControlOptions = new PanControlOptions() {Position = ControlPosition.Bottom_Left};

            Assert.That(options.ToString(),
                        Is.EqualTo(
                            ",{mapTypeControl:false,mapTypeId:google.maps.MapTypeId.ROADMAP,panControlOptions:{position:google.maps.ControlPosition.BOTTOM_LEFT}}"));
        }

        [Test]
        public void RotateControl_Renders_Option()
        {
            options.RotateControl = true;

            Assert.That(options.ToString(),
                        Is.EqualTo(",{mapTypeControl:false,mapTypeId:google.maps.MapTypeId.ROADMAP,rotateControl:true}"));
        }

        [Test]
        public void RotateControlOptions_Renders_Option()
        {
            options.RotateControlOptions = new RotateControlOptions() {Position = ControlPosition.Bottom_Left};

            Assert.That(options.ToString(),
                        Is.EqualTo(
                            ",{mapTypeControl:false,mapTypeId:google.maps.MapTypeId.ROADMAP,rotateControlOptions:{position:google.maps.ControlPosition.BOTTOM_LEFT}}"));
        }

        [Test]
        public void ScaleControl_Renders_Option()
        {
            options.ScaleControl = true;

            Assert.That(options.ToString(),
                        Is.EqualTo(",{mapTypeControl:false,mapTypeId:google.maps.MapTypeId.ROADMAP,scaleControl:true}"));
        }

        [Test]
        public void ScaleControlOptions_Renders_Option()
        {
            options.ScaleControlOptions = new ScaleControlOptions() {Position = ControlPosition.Bottom_Right};

            Assert.That(options.ToString(),
                        Is.EqualTo(
                            ",{mapTypeControl:false,mapTypeId:google.maps.MapTypeId.ROADMAP,scaleControlOptions:{position:google.maps.ControlPosition.BOTTOM_RIGHT}}"));
        }

        [Test]
        public void Scrollwheel_Renders_Option()
        {
            options.Scrollwheel = false;

            Assert.That(options.ToString(),
                        Is.EqualTo(",{mapTypeControl:false,mapTypeId:google.maps.MapTypeId.ROADMAP,scrollwheel:false}"));
        }

        [Test]
        public void StreetView_Renders_Option()
        {
            options.StreetView = new StreetViewPanorama("map", new StreetViewPanoramaOptions());

            Assert.That(options.ToString(),
                        Is.EqualTo(",{mapTypeControl:false,mapTypeId:google.maps.MapTypeId.ROADMAP,streetView:true}"));
        }

        [Test]
        public void StreetViewControl_Renders_Option()
        {
            options.StreetViewControl = true;

            Assert.That(options.ToString(),
                        Is.EqualTo(",{mapTypeControl:false,mapTypeId:google.maps.MapTypeId.ROADMAP,streetViewControl:true}"));
        }

        [Test]
        public void StreetViewControlOptions_Renders_Option()
        {
            options.StreetViewControlOptions = new StreetViewControlOptions() {Position = ControlPosition.Bottom_Left};

            Assert.That(options.ToString(),
                        Is.EqualTo(
                            ",{mapTypeControl:false,mapTypeId:google.maps.MapTypeId.ROADMAP,streetViewControlOptions:{position:google.maps.ControlPosition.BOTTOM_LEFT}}"));
        }

        [Test]
        public void Styles_Renders_Option()
        {
            options.Styles = new List<MapTypeStyle>()
                                 {
                                     new MapTypeStyle()
                                         {
                                             ElementType = MapTypeStyleElementType.All, 
                                             FeatureType = MapTypeStyleFeatureType.All, 
                                             Styler = new MapTypeStyler() {Color = Color.Aqua}
                                         }
                                 };

            Assert.That(options.ToString(), Is.EqualTo(",{mapTypeControl:false,mapTypeId:google.maps.MapTypeId.ROADMAP,styles:[{elementType:'all',featureType:'all',stylers:[{color:'#00FFFF'}]}]}"));
        }

        [Test]
        public void Tilt_Renders_Option()
        {
            options.Tilt = 45;

            Assert.That(options.ToString(), Is.EqualTo(",{mapTypeControl:false,mapTypeId:google.maps.MapTypeId.ROADMAP,tilt:45}"));
        }

        [Test]
        public void Zoom_Renders_Option()
        {
            options.Zoom = 7;

            Assert.That(options.ToString(), Is.EqualTo(",{mapTypeControl:false,mapTypeId:google.maps.MapTypeId.ROADMAP,zoom:7}"));
        }

        [Test]
        public void ZoomControl_Renders_Option()
        {
            options.ZoomControl = true;

            Assert.That(options.ToString(),
                        Is.EqualTo(",{mapTypeControl:false,mapTypeId:google.maps.MapTypeId.ROADMAP,zoomControl:true}"));
        }

        [Test]
        public void ZoomControlOptions_Renders_Option()
        {
            options.ZoomControlOptions = new ZoomControlOptions() {Position = ControlPosition.Bottom_Left};

            Assert.That(options.ToString(),
                        Is.EqualTo(
                            ",{mapTypeControl:false,mapTypeId:google.maps.MapTypeId.ROADMAP,zoomControlOptions:{position:google.maps.ControlPosition.BOTTOM_LEFT}}"));
        }
    }
}
