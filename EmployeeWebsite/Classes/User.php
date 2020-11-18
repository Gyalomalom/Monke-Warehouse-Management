<?php
class User {
  private $id;
  private $email;
  private $firstname;
  private $lastname;
  private $password;
  
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
}
?>