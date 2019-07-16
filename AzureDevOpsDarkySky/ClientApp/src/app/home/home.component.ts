//import { Component } from '@angular/core';
import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent {
  public forecasts: WeatherDarkSky = new WeatherDarkSky();
  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<WeatherDarkSky>(baseUrl + 'api/SampleData/Index').subscribe(result => {
      this.forecasts = result;
      console.log(this.forecasts);
    }, error => console.error(error));
  }
}


export class WeatherDarkSky {
  latitude: string;
  longitude: string;
  timezone: string;
  currently: Currently = new Currently();
}

export class Currently {
  apparentTemperature: string;
  cloudCover: string;
  dewPoint: string;
  humidity: string;
  icon: string;
  precipIntensity: string;
  precipProbability: string;
  pressure: string;
  summary: string;
  temperature: string;
  time: string;
  uvIndex: string;
  windBearing: string;
  windGust: string;
  windSpeed: string;
}
