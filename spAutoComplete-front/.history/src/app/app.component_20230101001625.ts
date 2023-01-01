import { Component } from "@angular/core";
import { AutoCompleteService } from "./services/autoComplete.service";

@Component({
  selector: "app-root",
  templateUrl: "./app.component.html",
  styleUrls: ["./app.component.css"],
})
export class AppComponent {
  async searchForAutoComplete(type: string, event: any) {
    return AutoCompleteService.matchPartial();
  }
}
