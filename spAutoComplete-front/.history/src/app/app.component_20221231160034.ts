import { Component } from "@angular/core";

@Component({
  selector: "app-root",
  templateUrl: "./app.component.html",
  styleUrls: ["./app.component.css"],
})
export class AppComponent {
  searchForAutoComplete(type: string, event: any) {
    console.log(event.target.value);
  }
}