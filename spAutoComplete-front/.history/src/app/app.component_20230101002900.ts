import { Component } from "@angular/core";
import { AutoCompleteService } from "./services/autoComplete.service";

@Component({
  selector: "app-root",
  templateUrl: "./app.component.html",
  styleUrls: ["./app.component.css"],
})
export class AppComponent {
  constructor(public _autoCompleteService: AutoCompleteService) {}
  async searchForAutoComplete(type: string, event: any) {
    return AutoCompleteService.ma;
    console.log(typeof AutoCompleteService);
  }
}
