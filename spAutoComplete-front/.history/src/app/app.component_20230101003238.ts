import { Component } from "@angular/core";
import { AutoCompleteService } from "./services/autoComplete.service";

export class AppComponent {
  constructor(public _autoCompleteService: AutoCompleteService) {}
  async searchForAutoComplete(type: string, event: any) {
    return _autoCompleteService.console.log(typeof AutoCompleteService);
  }
}
