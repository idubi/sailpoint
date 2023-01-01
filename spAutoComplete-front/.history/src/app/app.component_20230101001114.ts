import { Component } from "@angular/core";
import AutoCompleteService from "./services/autoComplete.service.js";

@Component({
  selector: "app-root",
  templateUrl: "./app.component.html",
  styleUrls: ["./app.component.css"],
})
export class AppComponent {
  searchForAutoComplete = async (type: string, event: any) => {
    return this.AutoCompleteService.matchPartial();
  };
}
