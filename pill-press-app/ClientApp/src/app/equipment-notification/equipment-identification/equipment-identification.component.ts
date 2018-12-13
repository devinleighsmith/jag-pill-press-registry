import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder } from '@angular/forms';
import { Subscription, zip } from 'rxjs';
import { ActivatedRoute, Router } from '@angular/router';
import { ApplicationDataService } from '../../services/adoxio-application-data.service';
import { Application } from '../../models/application.model';

@Component({
  selector: 'app-equipment-identification',
  templateUrl: './equipment-identification.component.html',
  styleUrls: ['./equipment-identification.component.scss']
})
export class EquipmentIdentificationComponent implements OnInit {
  form: FormGroup;
  busy: Subscription;
  equipmentId: string;
  busyPromise: Promise<any>;

  constructor(private route: ActivatedRoute,
    private router: Router,
    private applicationDataService: ApplicationDataService,
    private fb: FormBuilder) {
    this.equipmentId = this.route.snapshot.params.id;
  }

  ngOnInit() {
    this.form = this.fb.group({
      id: [],
      howWasEquipmentBuilt: [],
      howWasEquipmentBuiltOther: [],
      howWasEquipmentBuiltOtherCheck: [],
      nameOfManufacturer: [],
      equipmentMake: [],
      equipmentModel: [],
      serialNumber: [],
      howEquipmentBuiltDescription: [],
      personBusinessThatBuiltEquipment: [],
      serialNumberForCustomBuilt: [],
      customBuiltSerialNumber: [],
      serialNumberKeyPartDescription: [],

    });
    this.reloadData();
  }

  reloadData() {
    this.busy = this.applicationDataService.getApplicationById(this.equipmentId)
      .subscribe((data: Application) => {
        this.form.patchValue(data);
      }, error => {
        // debugger;
      });
  }

  markAsTouched() {

  }


  save(gotToReview: boolean) {
    if (this.form.valid || gotToReview === false) {
      const value = this.form.value;
      const saveList = [this.applicationDataService.updateApplication(value)];
      this.busyPromise = zip(...saveList)
        .toPromise()
        .then(res => {
          if (gotToReview) {
            this.router.navigateByUrl(`/equipment-notification/source/${this.equipmentId}`);
          } else {
            this.router.navigateByUrl(`/dashboard`);
            // this.reloadData();
          }
        }, err => {
          // todo: show errors;
        });
    }
  }

}
