import { Component } from "@angular/core";
import { AutoCompleteService } from "./services/autoComplete.service";

export class AppComponent {
  
  async searchForAutoComplete(type: string, event: any) {
    return .console.log(typeof AutoCompleteService);
  }
}
