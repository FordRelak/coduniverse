import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute, ParamMap } from '@angular/router';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { Spaceobject } from '../models/spaceobject';
import { SpaceObjectService } from '../services/space-object.service';
import { StarSystemService } from '../services/starsystem.service';
import { StarSystem } from '../models/star-system';

@Component({
  selector: 'app-form',
  templateUrl: './form.component.html',
  styleUrls: ['./form.component.scss']
})
export class FormComponent implements OnInit {

  id: string | undefined
  starSystemId!: string
  spaceObject: any
  type!: string;
  action: string | undefined;

  spaceObjectForm = new FormGroup({
    name: new FormControl('', [
      Validators.required,
    ]),
    age: new FormControl('', [
      Validators.required,
      Validators.max(2147483647),
      Validators.min(0)
    ]),
    diameter: new FormControl('', [
      Validators.required,
      Validators.max(2147483647),
      Validators.min(0)
    ]),
    mass: new FormControl('', [
      Validators.required,
      Validators.max(2147483647),
      Validators.min(0)
    ]),
    type: new FormControl('', [
      Validators.required,
    ]),
  })

  constructor(
    private route: ActivatedRoute,
    private spaceObjectService: SpaceObjectService,
    private starSystemService: StarSystemService
  ) { }

  ngOnInit(): void {
    this.route.queryParams.subscribe(params => {
      this.id = params['id'];
      this.starSystemId = params['starId'];
      this.type = params['type'];
      this.action = params['action'];
    });
    if (this.id != null) {
      switch (this.type) {
        case 'star':
          this.starSystemService.getStarSystem(this.id).subscribe((data: any) => {
            console.log(data)
            this.spaceObject = data;
            this.updateForm()
          });
          break;
        case 'object':
          this.spaceObjectService.getSpaceObject(this.id).subscribe((data: Spaceobject) => {
            this.spaceObject = data;
            this.updateForm()
          });
          break;
        default:
          break;
      }

    }
  }

  updateForm() {
    this.spaceObjectForm.patchValue({
      name: this.spaceObject?.name ?? "",
      age: this.spaceObject?.age ?? "",
      diameter: this.spaceObject?.diameter ?? "",
      mass: this.spaceObject?.mass ?? "",
      type: this.spaceObject?.type?.toString(),
    });
  }

  addOrUpdate() {
    switch (this.type) {
      case 'star':
        if (this.spaceObjectForm.controls['name'].valid && this.spaceObjectForm.controls['age'].valid) {
          let data = this.spaceObjectForm.value;
          data.id = this.id;
          this.starSystemService.addOrUpdate(data)?.subscribe((data: any) => window.location.href = "/");
        }
        break;
      case 'object':
        if (this.spaceObjectForm.valid) {
          let data = this.spaceObjectForm.value;
          data.id = this.id;
          data.starSystemId = this.starSystemId;
          this.spaceObjectService.addOrUpdate(data)?.subscribe((data: any) => window.location.href = "/");
        }
        break;
      default:
        break;
    }
  }

}
