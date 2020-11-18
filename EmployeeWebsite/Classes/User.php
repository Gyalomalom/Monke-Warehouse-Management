<?php
class User {
  private $id;
  private $email;
  private $firstname;
  private $lastname;
  private $password;
  private $phone;
  private $address;
  private $emergencyc;
  private $emergencynr;
  private $hours;
  private $dob;
  private $bsn;
  private $position;
  private $certificates;
  private $languages;
  private $ctype;
  private $duration;
  private $department;
  private $shiftpref;
  
  
  function set_id($id) {
    $this->id = $id;
  }
  function set_firstname($firstname) {
    $this->firstname = $firstname;
  }
  function set_lastname($lastname) {
    $this->lastname = $lastname;
  }
  function set_email($email) {
    $this->email = $email;
  }
  function set_pass($password) {
    $this->password = $password;
  }
  function set_phone($phone) {
    $this->phone = $phone;
  }
  function set_address($address) {
    $this->address = $address;
  }
  function set_emergencyc($emergencyc) {
    $this->emergencyc = $emergencyc;
  }
  function set_emergencynr($emergencynr) {
    $this->emergencynr = $emergencynr;
  }
  function set_hours($hours) {
    $this->hours = $hours;
  }
  function set_dob($dob) {
    $this->dob = $dob;
  }
  function set_bsn($bsn) {
    $this->bsn = $bsn;
  }
  function set_position($position) {
    $this->position = $position;
  }
  function set_certificates($certificates) {
    $this->certificates = $certificates;
  }
  function set_languages($languages) {
    $this->languages = $languages;
  }
  function set_ctype($ctype) {
    $this->ctype = $ctype;
  } 
  function set_duration($duration) {
    $this->duration = $duration;
  } 
  function set_department($department) {
    $this->department = $department;
  } 
  function set_shiftpref($shiftpref) {
    $this->shiftpref = $shiftpref;
  }  
  function get_id($id) {
  $this->id = $id;
  }
  function get_firstname() {
    return $this->firstname;
  }
  function get_lastname() {
    return $this->lastname;
  }
  function get_email() {
    return $this->email;
  }
  function get_pass() {
    return $this->password;
  }
  function get_phone() {
    return $this->phone;
  }
  function get_address() {
    return $this->address;
  }
  function get_emergencyc() {
    return $this->emergencyc;
  }
  function get_emergencynr() {
    return $this->emergencynr;
  }
  function get_hours() {
    return $this->hours;
  }
  function get_dob() {
    return $this->dob;
  }
  function get_bsn() {
    return $this->bsn;
  }
  function get_position() {
    return $this->position;
  }
  function get_certificates() {
    return $this->certificates;
  }
  function get_languages() {
    return $this->languages;
  }
  function get_ctype() {
    return $this->ctype;
  }
  function get_duration() {
    return $this->duration;
  }
  function get_department() {
    return $this->department;
  }
  function get_shiftpref() {
    return $this->shiftpref;
  }
  
}
?>